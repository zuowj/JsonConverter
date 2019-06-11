using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonConverter
{
    /// <summary>
    /// 通用弹出输入框
    /// Author:zuowenjun
    /// Date:2019-1-12
    /// </summary>
    public partial class FrmInputBox : Form
    {
        public string InputValue
        {
            get
            {
                return txtInput.Text;
            }
        }

        private FrmInputBox(string title, string tip, bool passwordMask = false)
        {
            InitializeComponent();

            this.Text = title;
            this.labTip.Text = tip;
            txtInput.UseSystemPasswordChar = passwordMask;
        }

        public static string Show(string title, string tip, bool passwordMask = false, Form ownerForm = null)
        {
            using (var inputBox = new FrmInputBox(title, tip, passwordMask))
            {
                if (inputBox.ShowDialog(ownerForm) == DialogResult.OK)
                {
                    return inputBox.InputValue;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }



    }
}
