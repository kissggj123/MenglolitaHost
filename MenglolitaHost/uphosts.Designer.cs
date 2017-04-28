namespace MenglolitaHost
{
    partial class uphosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uphosts));
            this.safe = new System.Windows.Forms.RadioButton();
            this.zhenchang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // safe
            // 
            this.safe.AutoSize = true;
            this.safe.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.safe.ForeColor = System.Drawing.Color.DodgerBlue;
            this.safe.Location = new System.Drawing.Point(12, 51);
            this.safe.Name = "safe";
            this.safe.Size = new System.Drawing.Size(290, 21);
            this.safe.TabIndex = 8;
            this.safe.Text = "安全模式：在默认模式更新失败的情况下可以选择";
            this.safe.UseVisualStyleBackColor = true;
            this.safe.CheckedChanged += new System.EventHandler(this.safe_CheckedChanged);
            // 
            // zhenchang
            // 
            this.zhenchang.AutoSize = true;
            this.zhenchang.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhenchang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.zhenchang.Location = new System.Drawing.Point(12, 24);
            this.zhenchang.Name = "zhenchang";
            this.zhenchang.Size = new System.Drawing.Size(338, 21);
            this.zhenchang.TabIndex = 7;
            this.zhenchang.Text = "默认模式：hosts可看YouTube（系统盘非C盘可选该项）";
            this.zhenchang.UseVisualStyleBackColor = true;
            this.zhenchang.CheckedChanged += new System.EventHandler(this.yhost_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "请选择更新方案";
            // 
            // progress
            // 
            this.progress.AutoEllipsis = true;
            this.progress.AutoSize = true;
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.progress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.progress.ForeColor = System.Drawing.Color.Red;
            this.progress.Location = new System.Drawing.Point(53, 75);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(121, 20);
            this.progress.TabIndex = 23;
            this.progress.Text = "更新线程准备就绪";
            this.progress.Click += new System.EventHandler(this.progress_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "状态：";
            // 
            // uphosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 108);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.safe);
            this.Controls.Add(this.zhenchang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uphosts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "更新hosts";
            this.Load += new System.EventHandler(this.uphosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton safe;
        private System.Windows.Forms.RadioButton zhenchang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}