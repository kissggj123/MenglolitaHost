using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenglolitaHost
{
    public partial class restore : Form
    {
        public restore()
        {
            InitializeComponent();
        }

        private void restorehosts_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak";
            if (!System.IO.Directory.Exists(Path + @"\" + "Hostbak"))
            {
                // 目录不存在，建立目录
                MessageBox.Show("备份的文件被你吃了嘛", "你别骗我");
                //return;
            }
            else
            {
                String oldPath = "C:\\Windows\\System32\\drivers\\etc\\hosts"; ;
                String bakPath = hostsbakurl.Text;
                bool isrewrite = true; //覆盖已存在的同名文件,false则反之
                System.IO.File.Copy(bakPath, oldPath, isrewrite);
                MessageBox.Show("Hosts恢复完成", "年轻人继续搞事情", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void restore_Load(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory + @"\"+"Hostbak";
            hostsbakurl.Visible = false;
            ts1.Text="";
            ts2.Text="";
            ts3.Text="";
            mainhosts.Checked = false;
            otherhosts.Checked = false;
            yourshostsbak.Checked = false;
            restorehosts.Enabled = false;
            if (File.Exists(Path + @"\" + "hosts"))
            {
                mainhosts.Enabled = true;
                ts1.Text = "可用";
            }
            else
            {
                mainhosts.Enabled = false;
                ts1.Text = "不可用";
            }
            if (File.Exists(Path + @"\"+"第三方源hosts备份" +@"\" + "hosts"))
            {
                otherhosts.Enabled = true;
                ts2.Text = "可用";
            }
            else
            {
                otherhosts.Enabled = false;
                ts2.Text = "不可用";
            }
            if (File.Exists(Path + @"\" + "自定义源hosts备份" + @"\" + "hosts"))
            {
                yourshostsbak.Enabled = true;
                ts3.Text = "可用";
            }
            else
            {
                yourshostsbak.Enabled = false;
                ts3.Text = "不可用";
            }
        }



        private void otherhosts_CheckedChanged(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak" + @"\" + "第三方源hosts备份";
            if (otherhosts.Checked)
                hostsbakurl.Text = Path2 + @"\" + "hosts";
            if (!System.IO.Directory.Exists(Path2))
            {
                restorehosts.Enabled = false;
            }
            else
            {
                restorehosts.Enabled = true;
            }
        }

        private void mainhosts_CheckedChanged(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak";
            if (mainhosts.Checked)
                hostsbakurl.Text = Path2 + @"\" + "hosts";
            if (!System.IO.Directory.Exists(Path2))
            {
                restorehosts.Enabled = false;
            }
            else
            {
                restorehosts.Enabled = true;
            }
        }

        private void yourshostsbak_CheckedChanged(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak" + @"\" + "自定义源hosts备份";
            if (yourshostsbak.Checked)
                hostsbakurl.Text = Path2 + @"\" + "hosts";
            if (!System.IO.Directory.Exists(Path2))
            {
                restorehosts.Enabled = false;
            }
            else
            {
                restorehosts.Enabled = true;
            }
        }
    }
}
    
