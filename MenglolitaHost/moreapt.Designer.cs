namespace MenglolitaHost
{
    partial class moreapt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moreapt));
            this.label1 = new System.Windows.Forms.Label();
            this.yourshostsupdate = new System.Windows.Forms.Button();
            this.yourshostsurl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入你需要获取更新的hosts镜像源\r\n该操作不会改变默认的hosts镜像源\r\n你每次最后更新的一条hosts镜像源会被记录在yoursapt.txt文件中\r\n" +
    "输入不正确的自定义源更新成功后可能无法正常使用";
            // 
            // yourshostsupdate
            // 
            this.yourshostsupdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yourshostsupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yourshostsupdate.ForeColor = System.Drawing.Color.OrangeRed;
            this.yourshostsupdate.Location = new System.Drawing.Point(278, 98);
            this.yourshostsupdate.Name = "yourshostsupdate";
            this.yourshostsupdate.Size = new System.Drawing.Size(93, 34);
            this.yourshostsupdate.TabIndex = 5;
            this.yourshostsupdate.Text = "开始更新";
            this.yourshostsupdate.UseVisualStyleBackColor = true;
            this.yourshostsupdate.Click += new System.EventHandler(this.yourshostsupdate_Click);
            // 
            // yourshostsurl
            // 
            this.yourshostsurl.Location = new System.Drawing.Point(14, 71);
            this.yourshostsurl.Name = "yourshostsurl";
            this.yourshostsurl.Size = new System.Drawing.Size(357, 21);
            this.yourshostsurl.TabIndex = 6;
            this.yourshostsurl.TextChanged += new System.EventHandler(this.yourshostsurl_TextChanged);
            // 
            // moreapt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 143);
            this.Controls.Add(this.yourshostsurl);
            this.Controls.Add(this.yourshostsupdate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "moreapt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "自定义hosts更新源";
            this.Load += new System.EventHandler(this.moreapt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yourshostsupdate;
        private System.Windows.Forms.TextBox yourshostsurl;
    }
}