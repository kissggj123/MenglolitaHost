#region CopyRight
/**************************************************************
   Copyright (c) 2015 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34209
   命名空间名称   :    $rootnamespace$
   文件名         :    Form1
   创建时间       :    2015-04-16 10:02:39
   用户所在的域   :    SWKJT410
   登录用户名     :    Star
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

namespace MenglolitaHost
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelUAC = new System.Windows.Forms.Panel();
            this.lbUAC = new System.Windows.Forms.Label();
            this.btnStartWithAdmin = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bakhost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WinPcap = new System.Windows.Forms.LinkLabel();
            this.hostlk = new System.Windows.Forms.LinkLabel();
            this.zhuabao = new System.Windows.Forms.Button();
            this.testhoost = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.qh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tools = new System.Windows.Forms.ToolStripMenuItem();
            this.hostedit = new System.Windows.Forms.ToolStripMenuItem();
            this.懒人模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置懒人模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouthosts = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.youTube专用hostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUAC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUAC
            // 
            this.panelUAC.Controls.Add(this.lbUAC);
            this.panelUAC.Controls.Add(this.btnStartWithAdmin);
            this.panelUAC.Location = new System.Drawing.Point(595, 342);
            this.panelUAC.Name = "panelUAC";
            this.panelUAC.Size = new System.Drawing.Size(346, 254);
            this.panelUAC.TabIndex = 6;
            this.panelUAC.Visible = false;
            // 
            // lbUAC
            // 
            this.lbUAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUAC.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUAC.Location = new System.Drawing.Point(83, 35);
            this.lbUAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUAC.Name = "lbUAC";
            this.lbUAC.Size = new System.Drawing.Size(199, 30);
            this.lbUAC.TabIndex = 2;
            this.lbUAC.Text = "需要管理员权限运行";
            this.lbUAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartWithAdmin
            // 
            this.btnStartWithAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartWithAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartWithAdmin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartWithAdmin.ForeColor = System.Drawing.Color.White;
            this.btnStartWithAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnStartWithAdmin.Image")));
            this.btnStartWithAdmin.Location = new System.Drawing.Point(84, 166);
            this.btnStartWithAdmin.Name = "btnStartWithAdmin";
            this.btnStartWithAdmin.Size = new System.Drawing.Size(168, 33);
            this.btnStartWithAdmin.TabIndex = 0;
            this.btnStartWithAdmin.Text = "请右键管理员";
            this.btnStartWithAdmin.UseVisualStyleBackColor = true;
            this.btnStartWithAdmin.Click += new System.EventHandler(this.btnStartWithAdmin_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(353, 196);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更新hosts";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(274, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(290, 111);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "注：Google、Gmail、维基百科、Twitter、Facebook等\r\n必须请用https加密方式打开\r\n（一般这些网站都是SSL加密链接）\r\n如谷歌学术：" +
    "https://scholar.google.com/\r\n如果不喜欢用谷歌香港\r\n可以以 https://www.google.com/ncr 方式访问\r\n(N" +
    "CR：No Country Redirect禁止国别跳转）\r\n";
            // 
            // bakhost
            // 
            this.bakhost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bakhost.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bakhost.ForeColor = System.Drawing.Color.Blue;
            this.bakhost.Location = new System.Drawing.Point(82, 196);
            this.bakhost.Name = "bakhost";
            this.bakhost.Size = new System.Drawing.Size(146, 37);
            this.bakhost.TabIndex = 11;
            this.bakhost.Text = "备份hosts";
            this.bakhost.UseVisualStyleBackColor = true;
            this.bakhost.Click += new System.EventHandler(this.bakhost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.WinPcap);
            this.groupBox1.Controls.Add(this.hostlk);
            this.groupBox1.Controls.Add(this.zhuabao);
            this.groupBox1.Controls.Add(this.testhoost);
            this.groupBox1.Controls.Add(this.restore);
            this.groupBox1.Controls.Add(this.qh);
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试功能";
            // 
            // WinPcap
            // 
            this.WinPcap.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.WinPcap.AutoSize = true;
            this.WinPcap.BackColor = System.Drawing.Color.Transparent;
            this.WinPcap.ForeColor = System.Drawing.Color.White;
            this.WinPcap.LinkColor = System.Drawing.Color.Yellow;
            this.WinPcap.Location = new System.Drawing.Point(354, 145);
            this.WinPcap.Name = "WinPcap";
            this.WinPcap.Size = new System.Drawing.Size(125, 12);
            this.WinPcap.TabIndex = 5;
            this.WinPcap.TabStop = true;
            this.WinPcap.Text = "工具运行报错请点这里";
            this.WinPcap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WinPcap_LinkClicked);
            // 
            // hostlk
            // 
            this.hostlk.ActiveLinkColor = System.Drawing.Color.Gold;
            this.hostlk.AutoSize = true;
            this.hostlk.LinkColor = System.Drawing.Color.Gold;
            this.hostlk.Location = new System.Drawing.Point(348, 77);
            this.hostlk.Name = "hostlk";
            this.hostlk.Size = new System.Drawing.Size(131, 12);
            this.hostlk.TabIndex = 4;
            this.hostlk.TabStop = true;
            this.hostlk.Text = "丢进你已有的hosts文件";
            this.hostlk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // zhuabao
            // 
            this.zhuabao.BackColor = System.Drawing.Color.White;
            this.zhuabao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zhuabao.ForeColor = System.Drawing.Color.Teal;
            this.zhuabao.Location = new System.Drawing.Point(341, 103);
            this.zhuabao.Name = "zhuabao";
            this.zhuabao.Size = new System.Drawing.Size(146, 39);
            this.zhuabao.TabIndex = 3;
            this.zhuabao.Text = "抓包测试工具";
            this.zhuabao.UseVisualStyleBackColor = false;
            this.zhuabao.Click += new System.EventHandler(this.button1_Click);
            // 
            // testhoost
            // 
            this.testhoost.BackColor = System.Drawing.Color.White;
            this.testhoost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testhoost.ForeColor = System.Drawing.Color.Teal;
            this.testhoost.Location = new System.Drawing.Point(341, 35);
            this.testhoost.Name = "testhoost";
            this.testhoost.Size = new System.Drawing.Size(146, 39);
            this.testhoost.TabIndex = 2;
            this.testhoost.Text = "写入已有的hosts";
            this.testhoost.UseVisualStyleBackColor = false;
            this.testhoost.Click += new System.EventHandler(this.testhoost_Click);
            // 
            // restore
            // 
            this.restore.BackColor = System.Drawing.Color.White;
            this.restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restore.ForeColor = System.Drawing.Color.Teal;
            this.restore.Location = new System.Drawing.Point(70, 103);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(146, 39);
            this.restore.TabIndex = 1;
            this.restore.Text = "恢复存档的hosts";
            this.restore.UseVisualStyleBackColor = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // qh
            // 
            this.qh.BackColor = System.Drawing.Color.White;
            this.qh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qh.ForeColor = System.Drawing.Color.Teal;
            this.qh.Location = new System.Drawing.Point(70, 35);
            this.qh.Name = "qh";
            this.qh.Size = new System.Drawing.Size(146, 39);
            this.qh.TabIndex = 0;
            this.qh.Text = "更新其他镜像源hosts";
            this.qh.UseVisualStyleBackColor = false;
            this.qh.Click += new System.EventHandler(this.qh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(69, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "针对断网破解，广告屏蔽";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(340, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "该操作会覆盖原hosts文件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(144, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "版本@1.5.6 Final Preview Version";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "编译者@北斗家老司机";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools,
            this.懒人模式ToolStripMenuItem,
            this.youTube专用hostsToolStripMenuItem,
            this.abouthosts});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tools
            // 
            this.tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostedit});
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(44, 21);
            this.tools.Text = "操作";
            // 
            // hostedit
            // 
            this.hostedit.Name = "hostedit";
            this.hostedit.Size = new System.Drawing.Size(143, 22);
            this.hostedit.Text = "hosts编辑器";
            this.hostedit.Click += new System.EventHandler(this.hostedit_Click);
            // 
            // 懒人模式ToolStripMenuItem
            // 
            this.懒人模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置懒人模式ToolStripMenuItem});
            this.懒人模式ToolStripMenuItem.Name = "懒人模式ToolStripMenuItem";
            this.懒人模式ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.懒人模式ToolStripMenuItem.Text = "懒人模式";
            // 
            // 配置懒人模式ToolStripMenuItem
            // 
            this.配置懒人模式ToolStripMenuItem.Name = "配置懒人模式ToolStripMenuItem";
            this.配置懒人模式ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.配置懒人模式ToolStripMenuItem.Text = "配置懒人模式";
            this.配置懒人模式ToolStripMenuItem.Click += new System.EventHandler(this.配置懒人模式ToolStripMenuItem_Click);
            // 
            // abouthosts
            // 
            this.abouthosts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.abouthosts.Name = "abouthosts";
            this.abouthosts.Size = new System.Drawing.Size(44, 21);
            this.abouthosts.Text = "关于";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(169, 22);
            this.about.Text = "Menglolita Host";
            this.about.Click += new System.EventHandler(this.menglolitaHostToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 100);
            this.label1.TabIndex = 18;
            this.label1.Text = "本程序用于更新hosts文件\r\n勿做其他用途\r\n遇上杀毒软件拦截请允许\r\n感谢所有用到的开源项目";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.MistyRose;
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(12, 469);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(576, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(12, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(559, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 21;
            // 
            // update
            // 
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.Teal;
            this.update.Location = new System.Drawing.Point(455, 441);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(98, 22);
            this.update.TabIndex = 22;
            this.update.Text = "检查hosts信息";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // youTube专用hostsToolStripMenuItem
            // 
            this.youTube专用hostsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHostsToolStripMenuItem});
            this.youTube专用hostsToolStripMenuItem.Name = "youTube专用hostsToolStripMenuItem";
            this.youTube专用hostsToolStripMenuItem.Size = new System.Drawing.Size(126, 21);
            this.youTube专用hostsToolStripMenuItem.Text = "YouTube专用hosts";
            this.youTube专用hostsToolStripMenuItem.Click += new System.EventHandler(this.youTube专用hostsToolStripMenuItem_Click);
            // 
            // goHostsToolStripMenuItem
            // 
            this.goHostsToolStripMenuItem.Name = "goHostsToolStripMenuItem";
            this.goHostsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.goHostsToolStripMenuItem.Text = "GoHosts";
            this.goHostsToolStripMenuItem.Click += new System.EventHandler(this.goHostsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 521);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bakhost);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelUAC);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 250);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menglolita Host 1.5.6 Final Preview Version";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelUAC.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUAC;
        private System.Windows.Forms.Label lbUAC;
        private System.Windows.Forms.Button btnStartWithAdmin;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bakhost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button testhoost;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.Button qh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button zhuabao;
        private System.Windows.Forms.LinkLabel hostlk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel WinPcap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tools;
        private System.Windows.Forms.ToolStripMenuItem hostedit;
        private System.Windows.Forms.ToolStripMenuItem abouthosts;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 懒人模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置懒人模式ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ToolStripMenuItem youTube专用hostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goHostsToolStripMenuItem;
    }
}
