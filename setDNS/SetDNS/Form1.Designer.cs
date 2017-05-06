namespace SetDNS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbAdapters = new System.Windows.Forms.ComboBox();
            this.txtPreferredDNS = new System.Windows.Forms.TextBox();
            this.lblPreferredDNS = new System.Windows.Forms.Label();
            this.lblAlternateDNS = new System.Windows.Forms.Label();
            this.txtAlternateDNS = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbDNSType = new System.Windows.Forms.ComboBox();
            this.lblDNS = new System.Windows.Forms.Label();
            this.cbAutomatic = new System.Windows.Forms.CheckBox();
            this.btnPingPrimary = new System.Windows.Forms.Button();
            this.btnPingSecondary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAdapters
            // 
            this.cbAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdapters.FormattingEnabled = true;
            this.cbAdapters.Location = new System.Drawing.Point(59, 21);
            this.cbAdapters.Name = "cbAdapters";
            this.cbAdapters.Size = new System.Drawing.Size(259, 20);
            this.cbAdapters.TabIndex = 12;
            this.cbAdapters.SelectedIndexChanged += new System.EventHandler(this.cbAdapters_SelectedIndexChanged);
            // 
            // txtPreferredDNS
            // 
            this.txtPreferredDNS.Location = new System.Drawing.Point(59, 103);
            this.txtPreferredDNS.Name = "txtPreferredDNS";
            this.txtPreferredDNS.Size = new System.Drawing.Size(200, 21);
            this.txtPreferredDNS.TabIndex = 10;
            this.txtPreferredDNS.TextChanged += new System.EventHandler(this.txtPreferredDNS_TextChanged);
            // 
            // lblPreferredDNS
            // 
            this.lblPreferredDNS.AutoSize = true;
            this.lblPreferredDNS.Location = new System.Drawing.Point(12, 103);
            this.lblPreferredDNS.Name = "lblPreferredDNS";
            this.lblPreferredDNS.Size = new System.Drawing.Size(47, 12);
            this.lblPreferredDNS.TabIndex = 9;
            this.lblPreferredDNS.Text = "第一DNS";
            this.lblPreferredDNS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPreferredDNS.Click += new System.EventHandler(this.lblPreferredDNS_Click);
            // 
            // lblAlternateDNS
            // 
            this.lblAlternateDNS.AutoSize = true;
            this.lblAlternateDNS.Location = new System.Drawing.Point(12, 133);
            this.lblAlternateDNS.Name = "lblAlternateDNS";
            this.lblAlternateDNS.Size = new System.Drawing.Size(47, 12);
            this.lblAlternateDNS.TabIndex = 8;
            this.lblAlternateDNS.Text = "第二DNS";
            // 
            // txtAlternateDNS
            // 
            this.txtAlternateDNS.Location = new System.Drawing.Point(59, 130);
            this.txtAlternateDNS.Name = "txtAlternateDNS";
            this.txtAlternateDNS.Size = new System.Drawing.Size(200, 21);
            this.txtAlternateDNS.TabIndex = 7;
            this.txtAlternateDNS.TextChanged += new System.EventHandler(this.txtAlternateDNS_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(196, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "修改DNS";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(277, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbDNSType
            // 
            this.cbDNSType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDNSType.FormattingEnabled = true;
            this.cbDNSType.Location = new System.Drawing.Point(59, 77);
            this.cbDNSType.Name = "cbDNSType";
            this.cbDNSType.Size = new System.Drawing.Size(259, 20);
            this.cbDNSType.TabIndex = 4;
            this.cbDNSType.SelectedIndexChanged += new System.EventHandler(this.cbDNSType_SelectedIndexChanged);
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.Location = new System.Drawing.Point(12, 80);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(47, 12);
            this.lblDNS.TabIndex = 3;
            this.lblDNS.Text = "DNS方案";
            // 
            // cbAutomatic
            // 
            this.cbAutomatic.Location = new System.Drawing.Point(59, 47);
            this.cbAutomatic.Name = "cbAutomatic";
            this.cbAutomatic.Size = new System.Drawing.Size(153, 24);
            this.cbAutomatic.TabIndex = 2;
            this.cbAutomatic.Text = "选中即可恢复默认模式";
            this.cbAutomatic.UseVisualStyleBackColor = true;
            this.cbAutomatic.CheckedChanged += new System.EventHandler(this.cbAutomatic_CheckedChanged);
            // 
            // btnPingPrimary
            // 
            this.btnPingPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPingPrimary.Location = new System.Drawing.Point(265, 101);
            this.btnPingPrimary.Name = "btnPingPrimary";
            this.btnPingPrimary.Size = new System.Drawing.Size(53, 23);
            this.btnPingPrimary.TabIndex = 1;
            this.btnPingPrimary.Text = "测试";
            this.btnPingPrimary.UseVisualStyleBackColor = true;
            this.btnPingPrimary.Click += new System.EventHandler(this.btnPingPrimary_Click);
            // 
            // btnPingSecondary
            // 
            this.btnPingSecondary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPingSecondary.Location = new System.Drawing.Point(265, 128);
            this.btnPingSecondary.Name = "btnPingSecondary";
            this.btnPingSecondary.Size = new System.Drawing.Size(53, 23);
            this.btnPingSecondary.TabIndex = 0;
            this.btnPingSecondary.Text = "测试";
            this.btnPingSecondary.UseVisualStyleBackColor = true;
            this.btnPingSecondary.Click += new System.EventHandler(this.btnPingSecondary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "网卡";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbAdapters);
            this.groupBox1.Controls.Add(this.btnPingSecondary);
            this.groupBox1.Controls.Add(this.txtPreferredDNS);
            this.groupBox1.Controls.Add(this.btnPingPrimary);
            this.groupBox1.Controls.Add(this.lblPreferredDNS);
            this.groupBox1.Controls.Add(this.cbAutomatic);
            this.groupBox1.Controls.Add(this.lblAlternateDNS);
            this.groupBox1.Controls.Add(this.lblDNS);
            this.groupBox1.Controls.Add(this.txtAlternateDNS);
            this.groupBox1.Controls.Add(this.cbDNSType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 174);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置方案";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "版本 1.6.7 OCD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(83, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "为保证DNS生效。请务必点击关闭按钮";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(83, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Host on Menglolita Host&&ShareX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS修改&更新";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ComboBox cbAdapters;
        private System.Windows.Forms.TextBox txtPreferredDNS;
        private System.Windows.Forms.Label lblPreferredDNS;
        private System.Windows.Forms.Label lblAlternateDNS;
        private System.Windows.Forms.TextBox txtAlternateDNS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbDNSType;
        private System.Windows.Forms.Label lblDNS;
        private System.Windows.Forms.CheckBox cbAutomatic;
        private System.Windows.Forms.Button btnPingPrimary;
        private System.Windows.Forms.Button btnPingSecondary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

