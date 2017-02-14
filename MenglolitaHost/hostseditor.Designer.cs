namespace MenglolitaHost
{
    partial class hostseditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hostseditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hosts操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openhosts = new System.Windows.Forms.ToolStripMenuItem();
            this.savehosts = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hosts操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hosts操作ToolStripMenuItem
            // 
            this.hosts操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openhosts,
            this.savehosts});
            this.hosts操作ToolStripMenuItem.Name = "hosts操作ToolStripMenuItem";
            this.hosts操作ToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.hosts操作ToolStripMenuItem.Text = "hosts操作";
            // 
            // openhosts
            // 
            this.openhosts.Name = "openhosts";
            this.openhosts.Size = new System.Drawing.Size(131, 22);
            this.openhosts.Text = "编辑hosts";
            this.openhosts.Click += new System.EventHandler(this.打开hostsToolStripMenuItem_Click);
            // 
            // savehosts
            // 
            this.savehosts.Name = "savehosts";
            this.savehosts.Size = new System.Drawing.Size(131, 22);
            this.savehosts.Text = "写入hosts";
            this.savehosts.Click += new System.EventHandler(this.写入hostsToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(698, 354);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "编辑器用于编辑添加hosts内容\n复制粘贴请用快捷键\n暂不支持自定义编辑其他位置的hosts\n修改前请进行主界面备份";
            // 
            // hostseditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 394);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "hostseditor";
            this.Text = "hosts编辑器";
            this.Load += new System.EventHandler(this.hostseditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hosts操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openhosts;
        private System.Windows.Forms.ToolStripMenuItem savehosts;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}