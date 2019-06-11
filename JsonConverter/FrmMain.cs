using Microsoft.CSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace JsonConverter
{
    /// <summary>
    /// JSONl转换器主界面窗体类
    /// author:zuowenjun
    /// 2019-6-11
    /// </summary>
    public partial class FrmMain : Form
    {
        private Assembly dyAssembly;

        public FrmMain()
        {
            InitializeComponent();
        }


        #region 自定义方法区

        private List<string> Parse(string csCode)
        {

            var provider = new CSharpCodeProvider();
            var cp = new CompilerParameters();
            cp.GenerateExecutable = false;
            cp.GenerateInMemory = true;
            cp.IncludeDebugInformation = false;
            //cp.ReferencedAssemblies.Add("mscorlib.dll");
            cp.ReferencedAssemblies.Add("System.dll");
            cp.ReferencedAssemblies.Add("System.Data.dll");
            cp.ReferencedAssemblies.Add("System.Linq.dll");
            cp.ReferencedAssemblies.Add("System.ComponentModel.DataAnnotations.dll");
            cp.ReferencedAssemblies.Add("Newtonsoft.Json.dll");

            CompilerResults result = provider.CompileAssemblyFromSource(cp, csCode);
            List<string> errList = new List<string>();
            if (result.Errors.Count > 0)
            {
                foreach (CompilerError err in result.Errors)
                {
                    errList.Add(string.Format("Line:{0},ErrorNumber:{1},ErrorText:{2}", err.Line, err.ErrorNumber, err.ErrorText));
                }

                MessageBox.Show("Compile error:\n" + string.Join("\n", errList));
                return null;
            }

            dyAssembly = result.CompiledAssembly;

            return dyAssembly.GetTypes().Select(t => t.FullName).ToList();
        }


        private string ToJsonString(string targetType)
        {
            if (dyAssembly == null)
            {
                MessageBox.Show("dyAssembly is null!");
                return null;
            }
            var type = dyAssembly.GetType(targetType);
            var typeConstructor = type.GetConstructor(Type.EmptyTypes);
            var obj = typeConstructor.Invoke(null);
            return JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings { DateFormatString = "yyyy-MM-dd HH:mm:ss" });
        }


        private string ToClassCode(JObject jObject, string className)
        {
            var classCodes = new Dictionary<string, string>();
            classCodes.Add(className, BuildClassCode(jObject, className, classCodes));

            StringBuilder codeBuidler = new StringBuilder();
            foreach (var code in classCodes)
            {
                codeBuidler.AppendLine(code.Value);
            }

            return codeBuidler.ToString();

        }


        private Dictionary<JTokenType, string> jTokenBaseTypeMappings = new Dictionary<JTokenType, string> {
            { JTokenType.Integer,"int" },{ JTokenType.Date,"DateTime" },{ JTokenType.Bytes,"byte[]"},{ JTokenType.Boolean,"bool"},{ JTokenType.String,"string"},
            { JTokenType.Null,"object"},{ JTokenType.Float,"float"},{ JTokenType.TimeSpan,"long"}
        };

        private string BuildClassCode(JObject jObject, string className, Dictionary<string, string> classCodes)
        {
            StringBuilder classBuidler = new StringBuilder();
            classBuidler.Append("public class " + className + " \r\n { \r\n");
            foreach (var jProp in jObject.Properties())
            {
                string propClassName = "object";

                if (jProp.Value.Type == JTokenType.Object)
                {

                    if (jProp.Value.HasValues)
                    {
                        propClassName = GetClassName(jProp.Name);
                        if (classCodes.ContainsKey(propClassName))
                        {
                            propClassName = className + propClassName;
                        }

                        classCodes.Add(propClassName, BuildClassCode((JObject)jProp.Value, propClassName, classCodes));
                    }

                    classBuidler.AppendFormat("public {0} {1} {2}\r\n", propClassName, jProp.Name, "{get;set;}");
                }
                else if (jProp.Value.Type == JTokenType.Array)
                {
                    if (jProp.Value.HasValues)
                    {
                        var jPropArrItem = jProp.Value.First;
                        if (jPropArrItem.Type == JTokenType.Object)
                        {
                            propClassName = GetClassName(jProp.Name);
                            if (classCodes.ContainsKey(propClassName))
                            {
                                propClassName = className + propClassName;
                            }
                            propClassName += "Item";

                            classCodes.Add(propClassName, BuildClassCode((JObject)jPropArrItem, propClassName, classCodes));
                        }
                        else
                        {
                            if (jTokenBaseTypeMappings.ContainsKey(jPropArrItem.Type))
                            {
                                propClassName = jTokenBaseTypeMappings[jPropArrItem.Type];
                            }
                            else
                            {
                                propClassName = jPropArrItem.Type.ToString();
                            }
                        }
                    }

                    classBuidler.AppendFormat("public List<{0}> {1} {2}\r\n", propClassName, jProp.Name, "{get;set;}");

                }
                else
                {
                    if (jTokenBaseTypeMappings.ContainsKey(jProp.Value.Type))
                    {
                        propClassName = jTokenBaseTypeMappings[jProp.Value.Type];
                    }
                    else
                    {
                        propClassName = jProp.Value.Type.ToString();
                    }

                    classBuidler.AppendFormat("public {0} {1} {2} \r\n", propClassName, jProp.Name, "{get;set;}");
                }

            }

            classBuidler.Append("\r\n } \r\n");

            return classBuidler.ToString();
        }



        private string GetClassName(string propName)
        {
            propName = propName.TrimStart('_').Trim();

            if (Regex.IsMatch(propName, @"^\d+"))
            {
                propName = "C" + propName;
            }

            return CultureInfo.GetCultureInfo("en-US").TextInfo.ToTitleCase(propName);
        }


        #endregion

        private void lnkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.zuowenjun.cn");
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string csCode = txtCode.Text;
            if (string.IsNullOrWhiteSpace(csCode))
            {
                MessageBox.Show("Class Code文本框内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbTypes.DataSource = Parse(csCode);

        }

        private void btnToJson_Click(object sender, EventArgs e)
        {
            string targetType = cmbTypes.Text.Trim();
            if (string.IsNullOrWhiteSpace(targetType))
            {
                MessageBox.Show("请先Parse解析获得类型列表并选择需要转换的类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtJson.Text = ToJsonString(targetType);

        }

        private void btnToClass_Click(object sender, EventArgs e)
        {
            string jsonStr = txtJson.Text.Trim();
            if (string.IsNullOrWhiteSpace(jsonStr))
            {
                MessageBox.Show("Json String文本框内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string className = FrmInputBox.Show("请输入要生成的Class Name", "请输入要生成的Class Name（Class Name应符合Csharp的编码命名规范）", false, this);
            if (string.IsNullOrWhiteSpace(className))
            {
                className = "Root";
            }

            try
            {
                var JObj = JObject.Parse(jsonStr);
                txtCode.Text = ToClassCode(JObj, className);
            }
            catch (Exception ex)
            {
                MessageBox.Show("转换出错，原因：" + ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }




}
