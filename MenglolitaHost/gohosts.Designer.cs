namespace MenglolitaHost
{
    partial class gohosts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gohosts));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gohostnoad = new System.Windows.Forms.RadioButton();
            this.gohostdefault = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "请选择更新的hosts版本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 84);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // gohostnoad
            // 
            this.gohostnoad.AutoSize = true;
            this.gohostnoad.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gohostnoad.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gohostnoad.Location = new System.Drawing.Point(12, 154);
            this.gohostnoad.Name = "gohostnoad";
            this.gohostnoad.Size = new System.Drawing.Size(74, 21);
            this.gohostnoad.TabIndex = 13;
            this.gohostnoad.Text = "去广告源";
            this.gohostnoad.UseVisualStyleBackColor = true;
            this.gohostnoad.CheckedChanged += new System.EventHandler(this.gohostnoad_CheckedChanged);
            // 
            // gohostdefault
            // 
            this.gohostdefault.AutoSize = true;
            this.gohostdefault.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gohostdefault.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gohostdefault.Location = new System.Drawing.Point(14, 127);
            this.gohostdefault.Name = "gohostdefault";
            this.gohostdefault.Size = new System.Drawing.Size(86, 21);
            this.gohostdefault.TabIndex = 12;
            this.gohostdefault.Text = "科学上网源";
            this.gohostdefault.UseVisualStyleBackColor = true;
            this.gohostdefault.CheckedChanged += new System.EventHandler(this.gohostdefault_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "状态：";
            // 
            // progress
            // 
            this.progress.AutoEllipsis = true;
            this.progress.AutoSize = true;
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.progress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress.ForeColor = System.Drawing.Color.Red;
            this.progress.Location = new System.Drawing.Point(57, 178);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(219, 20);
            this.progress.TabIndex = 25;
            this.progress.Text = "更新线程准备就绪，点击即可更新";
            // 
            // gohosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.gohostnoad);
            this.Controls.Add(this.gohostdefault);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gohosts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "更新YouTube专用hosts";
            this.Load += new System.EventHandler(this.gohosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton gohostnoad;
        private System.Windows.Forms.RadioButton gohostdefault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Timer timer1;
    }
}