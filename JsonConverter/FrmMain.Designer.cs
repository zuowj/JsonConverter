namespace JsonConverter
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panAction = new System.Windows.Forms.Panel();
            this.panCode = new System.Windows.Forms.Panel();
            this.panJson = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJson = new System.Windows.Forms.RichTextBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnToJson = new System.Windows.Forms.Button();
            this.btnToClass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkSite = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panAction.SuspendLayout();
            this.panCode.SuspendLayout();
            this.panJson.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panAction, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panJson, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 621);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panAction
            // 
            this.panAction.Controls.Add(this.lnkSite);
            this.panAction.Controls.Add(this.label3);
            this.panAction.Controls.Add(this.btnToClass);
            this.panAction.Controls.Add(this.btnToJson);
            this.panAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAction.Location = new System.Drawing.Point(460, 3);
            this.panAction.Name = "panAction";
            this.panAction.Size = new System.Drawing.Size(144, 615);
            this.panAction.TabIndex = 0;
            // 
            // panCode
            // 
            this.panCode.Controls.Add(this.btnParse);
            this.panCode.Controls.Add(this.cmbTypes);
            this.panCode.Controls.Add(this.txtCode);
            this.panCode.Controls.Add(this.label1);
            this.panCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCode.Location = new System.Drawing.Point(3, 3);
            this.panCode.Name = "panCode";
            this.panCode.Size = new System.Drawing.Size(451, 615);
            this.panCode.TabIndex = 1;
            // 
            // panJson
            // 
            this.panJson.Controls.Add(this.txtJson);
            this.panJson.Controls.Add(this.label2);
            this.panJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panJson.Location = new System.Drawing.Point(610, 3);
            this.panJson.Name = "panJson";
            this.panJson.Size = new System.Drawing.Size(451, 615);
            this.panJson.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Code(C#):";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Location = new System.Drawing.Point(9, 30);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(439, 576);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Json String:";
            // 
            // txtJson
            // 
            this.txtJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJson.Location = new System.Drawing.Point(10, 30);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(438, 576);
            this.txtJson.TabIndex = 1;
            this.txtJson.Text = "";
            // 
            // cmbTypes
            // 
            this.cmbTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(205, 7);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(243, 20);
            this.cmbTypes.TabIndex = 2;
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.Location = new System.Drawing.Point(124, 5);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 3;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnToJson
            // 
            this.btnToJson.Location = new System.Drawing.Point(38, 144);
            this.btnToJson.Name = "btnToJson";
            this.btnToJson.Size = new System.Drawing.Size(75, 23);
            this.btnToJson.TabIndex = 0;
            this.btnToJson.Text = "To Json >";
            this.btnToJson.UseVisualStyleBackColor = true;
            this.btnToJson.Click += new System.EventHandler(this.btnToJson_Click);
            // 
            // btnToClass
            // 
            this.btnToClass.Location = new System.Drawing.Point(38, 276);
            this.btnToClass.Name = "btnToClass";
            this.btnToClass.Size = new System.Drawing.Size(75, 23);
            this.btnToClass.TabIndex = 0;
            this.btnToClass.Text = "< To Class";
            this.btnToClass.UseVisualStyleBackColor = true;
            this.btnToClass.Click += new System.EventHandler(this.btnToClass_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(3, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 210);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // lnkSite
            // 
            this.lnkSite.AutoSize = true;
            this.lnkSite.Location = new System.Drawing.Point(48, 5);
            this.lnkSite.Name = "lnkSite";
            this.lnkSite.Size = new System.Drawing.Size(53, 12);
            this.lnkSite.TabIndex = 2;
            this.lnkSite.TabStop = true;
            this.lnkSite.Text = "联系作者";
            this.lnkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSite_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1080, 660);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zuowenjun JsonConverter -Json转换器 ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panAction.ResumeLayout(false);
            this.panAction.PerformLayout();
            this.panCode.ResumeLayout(false);
            this.panCode.PerformLayout();
            this.panJson.ResumeLayout(false);
            this.panJson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panAction;
        private System.Windows.Forms.Panel panCode;
        private System.Windows.Forms.Panel panJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtJson;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnToJson;
        private System.Windows.Forms.Button btnToClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkSite;
    }
}

