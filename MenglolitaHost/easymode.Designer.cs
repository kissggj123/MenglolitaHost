namespace MenglolitaHost
{
    partial class easymode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(easymode));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.qd = new System.Windows.Forms.Button();
            this.ty = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "清除旧的hosts并备份";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(12, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(174, 16);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "通过备份整合已下载的hosts";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // qd
            // 
            this.qd.Enabled = false;
            this.qd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qd.ForeColor = System.Drawing.Color.SandyBrown;
            this.qd.Location = new System.Drawing.Point(164, 68);
            this.qd.Name = "qd";
            this.qd.Size = new System.Drawing.Size(92, 32);
            this.qd.TabIndex = 13;
            this.qd.Text = "请先同意使用";
            this.qd.UseVisualStyleBackColor = true;
            this.qd.Click += new System.EventHandler(this.qd_Click);
            // 
            // ty
            // 
            this.ty.AutoSize = true;
            this.ty.Location = new System.Drawing.Point(12, 77);
            this.ty.Name = "ty";
            this.ty.Size = new System.Drawing.Size(132, 16);
            this.ty.TabIndex = 14;
            this.ty.Text = "我同意使用懒人模式";
            this.ty.UseVisualStyleBackColor = true;
            this.ty.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // easymode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(268, 107);
            this.Controls.Add(this.ty);
            this.Controls.Add(this.qd);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "easymode";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "懒人模式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button qd;
        private System.Windows.Forms.CheckBox ty;
    }
}