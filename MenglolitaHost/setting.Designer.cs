namespace MenglolitaHost
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconpath = new System.Windows.Forms.TextBox();
            this.myicon = new System.Windows.Forms.CheckBox();
            this.noshow = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boost = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.saveset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iconpath);
            this.groupBox1.Controls.Add(this.myicon);
            this.groupBox1.Controls.Add(this.noshow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 76);
            this.label2.TabIndex = 5;
            this.label2.Text = "自定义图标格式：ico格式，大小128*128\r\n文件名:ic_launcher\r\nPS：请在放入图标之后再次点击该选项\r\nPS2：以上功能均为重启程序后生效";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "自定义图标放置路径（可复制）：";
            // 
            // iconpath
            // 
            this.iconpath.Location = new System.Drawing.Point(7, 94);
            this.iconpath.Name = "iconpath";
            this.iconpath.ReadOnly = true;
            this.iconpath.Size = new System.Drawing.Size(391, 21);
            this.iconpath.TabIndex = 2;
            // 
            // myicon
            // 
            this.myicon.AutoSize = true;
            this.myicon.Location = new System.Drawing.Point(7, 43);
            this.myicon.Name = "myicon";
            this.myicon.Size = new System.Drawing.Size(84, 16);
            this.myicon.TabIndex = 1;
            this.myicon.Text = "自定义图标";
            this.myicon.UseVisualStyleBackColor = true;
            this.myicon.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // noshow
            // 
            this.noshow.AutoSize = true;
            this.noshow.Location = new System.Drawing.Point(7, 21);
            this.noshow.Name = "noshow";
            this.noshow.Size = new System.Drawing.Size(84, 16);
            this.noshow.TabIndex = 0;
            this.noshow.Text = "不显示图标";
            this.noshow.UseVisualStyleBackColor = true;
            this.noshow.CheckedChanged += new System.EventHandler(this.noshow_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boost);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试功能";
            // 
            // boost
            // 
            this.boost.AutoSize = true;
            this.boost.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boost.ForeColor = System.Drawing.Color.Red;
            this.boost.Location = new System.Drawing.Point(2, 39);
            this.boost.Name = "boost";
            this.boost.Size = new System.Drawing.Size(216, 19);
            this.boost.TabIndex = 4;
            this.boost.Text = "PS3：测试功能默认开启，无法关闭";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(7, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 16);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "启用加速";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // saveset
            // 
            this.saveset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveset.ForeColor = System.Drawing.Color.OrangeRed;
            this.saveset.Location = new System.Drawing.Point(324, 293);
            this.saveset.Name = "saveset";
            this.saveset.Size = new System.Drawing.Size(92, 32);
            this.saveset.TabIndex = 14;
            this.saveset.Text = "保存设置";
            this.saveset.UseVisualStyleBackColor = true;
            this.saveset.Click += new System.EventHandler(this.qd_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 338);
            this.Controls.Add(this.saveset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "程序设置";
            this.Load += new System.EventHandler(this.setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iconpath;
        private System.Windows.Forms.CheckBox myicon;
        private System.Windows.Forms.CheckBox noshow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label boost;
        private System.Windows.Forms.Button saveset;
        private System.Windows.Forms.Label label2;
    }
}