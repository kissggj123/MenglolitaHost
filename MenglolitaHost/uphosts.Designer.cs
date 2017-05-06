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
            this.notetext1 = new System.Windows.Forms.Label();
            this.notice1 = new System.Windows.Forms.Panel();
            this.tw = new System.Windows.Forms.PictureBox();
            this.fb = new System.Windows.Forms.PictureBox();
            this.yb = new System.Windows.Forms.PictureBox();
            this.gg = new System.Windows.Forms.PictureBox();
            this.notetext2 = new System.Windows.Forms.Label();
            this.notice1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gg)).BeginInit();
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
            // notetext1
            // 
            this.notetext1.AutoSize = true;
            this.notetext1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notetext1.ForeColor = System.Drawing.Color.Red;
            this.notetext1.Location = new System.Drawing.Point(28, 0);
            this.notetext1.Name = "notetext1";
            this.notetext1.Size = new System.Drawing.Size(288, 16);
            this.notetext1.TabIndex = 25;
            this.notetext1.Text = "PS：正确使用hosts访问被墙网站的方式";
            this.notetext1.Click += new System.EventHandler(this.steptext1_Click);
            // 
            // notice1
            // 
            this.notice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notice1.Controls.Add(this.notetext2);
            this.notice1.Controls.Add(this.tw);
            this.notice1.Controls.Add(this.fb);
            this.notice1.Controls.Add(this.yb);
            this.notice1.Controls.Add(this.gg);
            this.notice1.Controls.Add(this.notetext1);
            this.notice1.Location = new System.Drawing.Point(13, 98);
            this.notice1.Name = "notice1";
            this.notice1.Size = new System.Drawing.Size(345, 208);
            this.notice1.TabIndex = 26;
            // 
            // tw
            // 
            this.tw.BackColor = System.Drawing.Color.Transparent;
            this.tw.Image = global::MenglolitaHost.Properties.Resources.twitter;
            this.tw.Location = new System.Drawing.Point(41, 131);
            this.tw.Name = "tw";
            this.tw.Size = new System.Drawing.Size(206, 32);
            this.tw.TabIndex = 29;
            this.tw.TabStop = false;
            // 
            // fb
            // 
            this.fb.BackColor = System.Drawing.Color.Transparent;
            this.fb.Image = global::MenglolitaHost.Properties.Resources.facebook;
            this.fb.Location = new System.Drawing.Point(41, 93);
            this.fb.Name = "fb";
            this.fb.Size = new System.Drawing.Size(263, 32);
            this.fb.TabIndex = 28;
            this.fb.TabStop = false;
            // 
            // yb
            // 
            this.yb.BackColor = System.Drawing.Color.Transparent;
            this.yb.Image = global::MenglolitaHost.Properties.Resources.youtube;
            this.yb.Location = new System.Drawing.Point(41, 55);
            this.yb.Name = "yb";
            this.yb.Size = new System.Drawing.Size(247, 32);
            this.yb.TabIndex = 27;
            this.yb.TabStop = false;
            // 
            // gg
            // 
            this.gg.BackColor = System.Drawing.Color.Transparent;
            this.gg.Image = global::MenglolitaHost.Properties.Resources.google1;
            this.gg.Location = new System.Drawing.Point(41, 19);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(247, 30);
            this.gg.TabIndex = 26;
            this.gg.TabStop = false;
            // 
            // notetext2
            // 
            this.notetext2.AutoSize = true;
            this.notetext2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notetext2.ForeColor = System.Drawing.Color.Red;
            this.notetext2.Location = new System.Drawing.Point(3, 178);
            this.notetext2.Name = "notetext2";
            this.notetext2.Size = new System.Drawing.Size(336, 16);
            this.notetext2.TabIndex = 30;
            this.notetext2.Text = "PS2：请务必输入为 https:// 否则会无法打开";
            // 
            // uphosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 318);
            this.Controls.Add(this.notice1);
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
            this.notice1.ResumeLayout(false);
            this.notice1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gg)).EndInit();
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
        private System.Windows.Forms.Label notetext1;
        private System.Windows.Forms.Panel notice1;
        private System.Windows.Forms.PictureBox gg;
        private System.Windows.Forms.PictureBox yb;
        private System.Windows.Forms.PictureBox tw;
        private System.Windows.Forms.PictureBox fb;
        private System.Windows.Forms.Label notetext2;
    }
}