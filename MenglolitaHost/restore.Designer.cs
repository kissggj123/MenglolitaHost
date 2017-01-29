namespace MenglolitaHost
{
    partial class restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restore));
            this.label1 = new System.Windows.Forms.Label();
            this.restorehosts = new System.Windows.Forms.Button();
            this.mainhosts = new System.Windows.Forms.RadioButton();
            this.otherhosts = new System.Windows.Forms.RadioButton();
            this.hostsbakurl = new System.Windows.Forms.Label();
            this.yourshostsbak = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "请选择需要恢复的hosts存档文件";
            // 
            // restorehosts
            // 
            this.restorehosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorehosts.ForeColor = System.Drawing.Color.DodgerBlue;
            this.restorehosts.Location = new System.Drawing.Point(195, 136);
            this.restorehosts.Name = "restorehosts";
            this.restorehosts.Size = new System.Drawing.Size(75, 23);
            this.restorehosts.TabIndex = 8;
            this.restorehosts.Text = "恢复hosts";
            this.restorehosts.UseVisualStyleBackColor = true;
            this.restorehosts.Click += new System.EventHandler(this.restorehosts_Click);
            // 
            // mainhosts
            // 
            this.mainhosts.AutoSize = true;
            this.mainhosts.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.mainhosts.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.mainhosts.Location = new System.Drawing.Point(14, 38);
            this.mainhosts.Name = "mainhosts";
            this.mainhosts.Size = new System.Drawing.Size(146, 21);
            this.mainhosts.TabIndex = 9;
            this.mainhosts.Text = "通过主界面产生备份的";
            this.mainhosts.UseVisualStyleBackColor = true;
            this.mainhosts.CheckedChanged += new System.EventHandler(this.mainhosts_CheckedChanged);
            // 
            // otherhosts
            // 
            this.otherhosts.AutoSize = true;
            this.otherhosts.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.otherhosts.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.otherhosts.Location = new System.Drawing.Point(14, 66);
            this.otherhosts.Name = "otherhosts";
            this.otherhosts.Size = new System.Drawing.Size(203, 21);
            this.otherhosts.TabIndex = 10;
            this.otherhosts.Text = "通过更新其他源hosts产生备份的";
            this.otherhosts.UseVisualStyleBackColor = true;
            this.otherhosts.CheckedChanged += new System.EventHandler(this.otherhosts_CheckedChanged);
            // 
            // hostsbakurl
            // 
            this.hostsbakurl.AutoSize = true;
            this.hostsbakurl.Location = new System.Drawing.Point(13, 114);
            this.hostsbakurl.Name = "hostsbakurl";
            this.hostsbakurl.Size = new System.Drawing.Size(0, 12);
            this.hostsbakurl.TabIndex = 11;
            this.hostsbakurl.Visible = false;
            // 
            // yourshostsbak
            // 
            this.yourshostsbak.AutoSize = true;
            this.yourshostsbak.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.yourshostsbak.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.yourshostsbak.Location = new System.Drawing.Point(13, 95);
            this.yourshostsbak.Name = "yourshostsbak";
            this.yourshostsbak.Size = new System.Drawing.Size(215, 21);
            this.yourshostsbak.TabIndex = 12;
            this.yourshostsbak.Text = "通过更新自定义源hosts产生的备份";
            this.yourshostsbak.UseVisualStyleBackColor = true;
            this.yourshostsbak.CheckedChanged += new System.EventHandler(this.yourshostsbak_CheckedChanged);
            // 
            // restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 171);
            this.Controls.Add(this.yourshostsbak);
            this.Controls.Add(this.hostsbakurl);
            this.Controls.Add(this.otherhosts);
            this.Controls.Add(this.mainhosts);
            this.Controls.Add(this.restorehosts);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "restore";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "恢复hosts";
            this.Load += new System.EventHandler(this.restore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restorehosts;
        private System.Windows.Forms.RadioButton mainhosts;
        private System.Windows.Forms.RadioButton otherhosts;
        private System.Windows.Forms.Label hostsbakurl;
        private System.Windows.Forms.RadioButton yourshostsbak;
    }
}