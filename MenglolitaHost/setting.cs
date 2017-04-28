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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void setting_Load(object sender, EventArgs e)
        {
            //启动工作
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string ico = Path + "Confion" + @"\" + "ic_launcher.ico";
            //
            if (File.Exists(Path + "Confion" + @"\" + "ic_launcher.ico"))
            {
                //noshow.Checked = true;
                myicon.Checked = true;
                myicon.Enabled = true;
                iconpath.Text = ico;
            }
            else
            {
                //noshow.Checked = false;
                myicon.Checked = false;
                myicon.Enabled = false;
                iconpath.Text = "自定义图标不存在,请将图标名字修改为ic_launcher.ico并复制到Confion目录下";
                //移除配置文件
                string filename = Path + "Confion" + @"\" + "myicon.mos";
                string filename2 = Path + "Confion" + @"\" + "ic_launcher.ico";
                //string ico = Path + "Confion" + @"\" + "ic_launcher.ico";
                //iconpath.Text = ico;
                //iconpath.Enabled = false;
                File.Delete(filename);
               // File.Delete(filename2);
            }
            if (File.Exists(Path + "Confion" + @"\" + "myicon.mos"))
            {
                //noshow.Checked = true;
                myicon.Checked = true;
            }
            else
            {
                //noshow.Checked = false;
                myicon.Checked = false;
               //
                //iconpath.Text = " ";
                //iconpath.Enabled = false;
              //
                //移除配置文件
                //string filename = Path + "Confion" + @"\" + "myicon.mos";
            }
            if (File.Exists(Path + "Confion" + @"\" + "noshow.mos"))
            {
                noshow.Checked = true;
                //myicon.Checked = true;
            }
            else
            {
                noshow.Checked = false;
                //myicon.Checked = false;
                //移除配置文件
                //string filename = Path + "Confion" + @"\" + "myicon.mos";
            }
        }

        private void noshow_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void qd_Click(object sender, EventArgs e)
        {
            if (noshow.CheckState == CheckState.Checked)
            {
                string Path = AppDomain.CurrentDomain.BaseDirectory;
                string ico = Path + "Confion" + @"\" + "ic_launcher.ico";
                iconpath.Enabled = true;
                iconpath.Text = ico;
                string filename = Path + "Confion" + @"\" + "noshow.mos";
                string word = iconpath.Text;
                FileStream fs = File.Create(filename);  //创建文件
                fs.Close();
                StreamWriter sw = new StreamWriter(filename);  //创建写入流
                sw.Write("不显示图标配置文件" + "{" + word + "}");
                sw.Flush();
                sw.Close();
                this.Close();
                //MessageBox.Show("偏好设置保存完成", "已配置", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (noshow.CheckState == CheckState.Unchecked)
            {
                string Path = AppDomain.CurrentDomain.BaseDirectory;
                string filename = Path + "Confion" + @"\" + "noshow.mos";
                File.Delete(filename);
                this.Close();
                //MessageBox.Show("偏好设置保存完成", "已配置", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //
            }
            //
            if (myicon.CheckState == CheckState.Checked)
            {
                string Path = AppDomain.CurrentDomain.BaseDirectory;
                string ico = Path + "Confion" + @"\" + "ic_launcher.ico";
                iconpath.Text = ico;
                string filename = Path + "Confion" + @"\" + "myicon.mos";
                string word = iconpath.Text;
                FileStream fs = File.Create(filename);  //创建文件
                fs.Close();
                StreamWriter sw = new StreamWriter(filename);  //创建写入流
                sw.Write("替换图标路径" + "{" + word + "}");
                sw.Flush();
                sw.Close();
                this.Close();
                //MessageBox.Show("偏好设置保存完成", "已配置", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (myicon.CheckState == CheckState.Unchecked)
            {
                string Path = AppDomain.CurrentDomain.BaseDirectory;
                string filename = Path + "Confion" + @"\" + "myicon.mos";
                string filename2 = Path + "Confion" + @"\" + "ic_launcher.ico";
                //iconpath.Text = " ";
                //iconpath.Enabled = false;
                File.Delete(filename);
                File.Delete(filename2);
                //删除文件
                this.Close();
                //MessageBox.Show("偏好设置保存完成", "已配置", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
            }
        }
    }
}
