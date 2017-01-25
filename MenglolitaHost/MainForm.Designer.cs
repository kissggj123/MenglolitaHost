#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    Form1
   创建时间       :    2015-04-16 10:02:39
   用户所在的域   :    SWKJT410
   登录用户名     :    Star
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

namespace MenglolitaHost
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelUAC = new System.Windows.Forms.Panel();
            this.lbUAC = new System.Windows.Forms.Label();
            this.btnStartWithAdmin = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bakhost = new System.Windows.Forms.Button();
            this.panelUAC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUAC
            // 
            this.panelUAC.Controls.Add(this.lbUAC);
            this.panelUAC.Controls.Add(this.btnStartWithAdmin);
            this.panelUAC.Location = new System.Drawing.Point(576, 335);
            this.panelUAC.Name = "panelUAC";
            this.panelUAC.Size = new System.Drawing.Size(346, 254);
            this.panelUAC.TabIndex = 6;
            this.panelUAC.Visible = false;
            // 
            // lbUAC
            // 
            this.lbUAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUAC.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUAC.Location = new System.Drawing.Point(83, 35);
            this.lbUAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUAC.Name = "lbUAC";
            this.lbUAC.Size = new System.Drawing.Size(199, 30);
            this.lbUAC.TabIndex = 2;
            this.lbUAC.Text = "需要管理员权限运行";
            this.lbUAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartWithAdmin
            // 
            this.btnStartWithAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartWithAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartWithAdmin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartWithAdmin.ForeColor = System.Drawing.Color.White;
            this.btnStartWithAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnStartWithAdmin.Image")));
            this.btnStartWithAdmin.Location = new System.Drawing.Point(84, 166);
            this.btnStartWithAdmin.Name = "btnStartWithAdmin";
            this.btnStartWithAdmin.Size = new System.Drawing.Size(168, 33);
            this.btnStartWithAdmin.TabIndex = 0;
            this.btnStartWithAdmin.Text = "请右键管理员";
            this.btnStartWithAdmin.UseVisualStyleBackColor = true;
            this.btnStartWithAdmin.Click += new System.EventHandler(this.btnStartWithAdmin_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(348, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "开始更新Host";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 100);
            this.label1.TabIndex = 8;
            this.label1.Text = "本程序用于更新Host文件\r\n勿做其他用途\r\nBy 北斗家老司机\r\n遇上杀毒软件拦截请允许";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(290, 111);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "注：Google、Gmail、维基百科、Twitter、Facebook等\r\n必须请用https加密方式打开\r\n（一般这些网站都是SSL加密链接）\r\n如谷歌学术：" +
    "https://scholar.google.com/\r\n如果不喜欢用谷歌香港\r\n可以以 https://www.google.com/ncr 方式访问\r\n(N" +
    "CR：No Country Redirect禁止国别跳转）\r\n";
            // 
            // bakhost
            // 
            this.bakhost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bakhost.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bakhost.ForeColor = System.Drawing.Color.Blue;
            this.bakhost.Location = new System.Drawing.Point(86, 161);
            this.bakhost.Name = "bakhost";
            this.bakhost.Size = new System.Drawing.Size(146, 37);
            this.bakhost.TabIndex = 11;
            this.bakhost.Text = "备份Host";
            this.bakhost.UseVisualStyleBackColor = true;
            this.bakhost.Click += new System.EventHandler(this.bakhost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 211);
            this.Controls.Add(this.bakhost);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelUAC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 250);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menglolita Host 1.1 alpha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelUAC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUAC;
        private System.Windows.Forms.Label lbUAC;
        private System.Windows.Forms.Button btnStartWithAdmin;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bakhost;
    }
}
