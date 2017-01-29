namespace MenglolitaHost
{
    partial class aptget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aptget));
            this.qd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yhost = new System.Windows.Forms.RadioButton();
            this.adfqhosts = new System.Windows.Forms.RadioButton();
            this.twotoone = new System.Windows.Forms.RadioButton();
            this.url = new System.Windows.Forms.Label();
            this.moreapt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qd
            // 
            this.qd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qd.ForeColor = System.Drawing.Color.Blue;
            this.qd.Location = new System.Drawing.Point(289, 132);
            this.qd.Name = "qd";
            this.qd.Size = new System.Drawing.Size(86, 32);
            this.qd.TabIndex = 1;
            this.qd.Text = "开始更新";
            this.qd.UseVisualStyleBackColor = true;
            this.qd.Click += new System.EventHandler(this.qd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择其他的hosts镜像源\r\n该操作不会改变默认的hosts镜像源";
            // 
            // yhost
            // 
            this.yhost.AutoSize = true;
            this.yhost.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yhost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.yhost.Location = new System.Drawing.Point(12, 40);
            this.yhost.Name = "yhost";
            this.yhost.Size = new System.Drawing.Size(374, 21);
            this.yhost.TabIndex = 5;
            this.yhost.Text = "vokins yhosts：屏蔽国内广告专用（部分会失效，不建议常用）";
            this.yhost.UseVisualStyleBackColor = true;
            this.yhost.CheckedChanged += new System.EventHandler(this.yhost_CheckedChanged);
            // 
            // adfqhosts
            // 
            this.adfqhosts.AutoSize = true;
            this.adfqhosts.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adfqhosts.ForeColor = System.Drawing.Color.DodgerBlue;
            this.adfqhosts.Location = new System.Drawing.Point(12, 67);
            this.adfqhosts.Name = "adfqhosts";
            this.adfqhosts.Size = new System.Drawing.Size(324, 21);
            this.adfqhosts.TabIndex = 6;
            this.adfqhosts.Text = "sy618 hosts ：被墙网站等基础数据（可看YouTube）";
            this.adfqhosts.UseVisualStyleBackColor = true;
            this.adfqhosts.CheckedChanged += new System.EventHandler(this.adfqhosts_CheckedChanged);
            // 
            // twotoone
            // 
            this.twotoone.AutoSize = true;
            this.twotoone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.twotoone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.twotoone.Location = new System.Drawing.Point(12, 94);
            this.twotoone.Name = "twotoone";
            this.twotoone.Size = new System.Drawing.Size(221, 21);
            this.twotoone.TabIndex = 7;
            this.twotoone.Text = "整合的host：用于去广告和被墙网站";
            this.twotoone.UseVisualStyleBackColor = true;
            this.twotoone.CheckedChanged += new System.EventHandler(this.twotoone_CheckedChanged);
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.BackColor = System.Drawing.Color.Transparent;
            this.url.Location = new System.Drawing.Point(12, 137);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(0, 12);
            this.url.TabIndex = 8;
            this.url.Visible = false;
            // 
            // moreapt
            // 
            this.moreapt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.moreapt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreapt.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.moreapt.Location = new System.Drawing.Point(163, 132);
            this.moreapt.Name = "moreapt";
            this.moreapt.Size = new System.Drawing.Size(112, 32);
            this.moreapt.TabIndex = 9;
            this.moreapt.Text = "使用自定义更新源";
            this.moreapt.UseVisualStyleBackColor = true;
            this.moreapt.Visible = false;
            this.moreapt.Click += new System.EventHandler(this.moreapt_Click);
            // 
            // aptget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 172);
            this.Controls.Add(this.moreapt);
            this.Controls.Add(this.url);
            this.Controls.Add(this.twotoone);
            this.Controls.Add(this.adfqhosts);
            this.Controls.Add(this.yhost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aptget";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "hosts镜像源";
            this.Load += new System.EventHandler(this.aptget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton yhost;
        private System.Windows.Forms.RadioButton adfqhosts;
        private System.Windows.Forms.RadioButton twotoone;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Button moreapt;
    }
}