namespace MenglolitaHost
{
    partial class update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update));
            this.version = new System.Windows.Forms.Label();
            this.version2 = new System.Windows.Forms.Label();
            this.updateexe = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.version.ForeColor = System.Drawing.Color.Black;
            this.version.Location = new System.Drawing.Point(12, 19);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(200, 17);
            this.version.TabIndex = 17;
            this.version.Text = "版本 1.5.8 Final Preview Version";
            // 
            // version2
            // 
            this.version2.AutoSize = true;
            this.version2.BackColor = System.Drawing.Color.Transparent;
            this.version2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.version2.ForeColor = System.Drawing.Color.Black;
            this.version2.Location = new System.Drawing.Point(12, 45);
            this.version2.Name = "version2";
            this.version2.Size = new System.Drawing.Size(200, 17);
            this.version2.TabIndex = 18;
            this.version2.Text = "版本 1.5.8 Final Preview Version";
            // 
            // updateexe
            // 
            this.updateexe.BackColor = System.Drawing.Color.White;
            this.updateexe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateexe.ForeColor = System.Drawing.Color.Orange;
            this.updateexe.Location = new System.Drawing.Point(218, 23);
            this.updateexe.Name = "updateexe";
            this.updateexe.Size = new System.Drawing.Size(99, 39);
            this.updateexe.TabIndex = 19;
            this.updateexe.Text = "更新程序";
            this.updateexe.UseVisualStyleBackColor = false;
            this.updateexe.Click += new System.EventHandler(this.updateexe_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(421, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "准备就绪";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "99.4251%";
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.White;
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.ForeColor = System.Drawing.Color.Orange;
            this.clean.Location = new System.Drawing.Point(334, 23);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(99, 39);
            this.clean.TabIndex = 23;
            this.clean.Text = "清理升级文件";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 118);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.updateexe);
            this.Controls.Add(this.version2);
            this.Controls.Add(this.version);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "update";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "更新升级";
            this.Load += new System.EventHandler(this.update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label version2;
        private System.Windows.Forms.Button updateexe;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clean;
    }
}