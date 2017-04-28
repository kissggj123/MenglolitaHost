namespace MH2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adfqhosts = new System.Windows.Forms.RadioButton();
            this.yhost = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.qd = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // adfqhosts
            // 
            this.adfqhosts.AutoSize = true;
            this.adfqhosts.Enabled = false;
            this.adfqhosts.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adfqhosts.ForeColor = System.Drawing.Color.DodgerBlue;
            this.adfqhosts.Location = new System.Drawing.Point(12, 51);
            this.adfqhosts.Name = "adfqhosts";
            this.adfqhosts.Size = new System.Drawing.Size(242, 21);
            this.adfqhosts.TabIndex = 9;
            this.adfqhosts.Text = "否：我觉得不是很变态但是我还是想关闭";
            this.adfqhosts.UseVisualStyleBackColor = true;
            // 
            // yhost
            // 
            this.yhost.AutoSize = true;
            this.yhost.Enabled = false;
            this.yhost.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yhost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.yhost.Location = new System.Drawing.Point(12, 24);
            this.yhost.Name = "yhost";
            this.yhost.Size = new System.Drawing.Size(146, 21);
            this.yhost.TabIndex = 8;
            this.yhost.Text = "是：我要关闭变态温蒂";
            this.yhost.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "温蒂是否又蠢又笨又变态";
            // 
            // qd
            // 
            this.qd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qd.ForeColor = System.Drawing.Color.Blue;
            this.qd.Location = new System.Drawing.Point(218, 78);
            this.qd.Name = "qd";
            this.qd.Size = new System.Drawing.Size(86, 32);
            this.qd.TabIndex = 10;
            this.qd.Text = "开始关闭";
            this.qd.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 89);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 12);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "我暂时还不想选择";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 116);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.qd);
            this.Controls.Add(this.adfqhosts);
            this.Controls.Add(this.yhost);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置 关闭温蒂 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton adfqhosts;
        private System.Windows.Forms.RadioButton yhost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button qd;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

