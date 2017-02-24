using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace MenglolitaHost
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
            FileVersionInfo myFileVersion = FileVersionInfo.GetVersionInfo(System.Windows.Forms.Application.ExecutablePath);
            version2.Text = "当前程序版本："+myFileVersion.FileVersion; 
            version.Text = "当前组件版本："+System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            label2.Text = "";
        }

        private void updateexe_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "update";
            if (!System.IO.Directory.Exists(Path + @"\" + "update"))
            {
                // 目录不存在，建立目录
                System.IO.Directory.CreateDirectory(Path + @"\" + "update");
            }
            if (File.Exists(Path2 + @"\" + "Hosts update.exe"))
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Path2 + @"\" + "Hosts update.exe";
                proc.Start();
            }
            else
            {
                DownloadFile("https://github.com/kissggj123/MenglolitaHost/raw/master/package/update/update.exe", Path2 + @"\" + "Hosts update.exe", progressBar1, label1);
            }
            //DownloadFile("https://github.com/kissggj123/MenglolitaHost/raw/master/package/update/update.exe", Path2+@"\"+"Host update.exe", progressBar1, label1);
        }

        public void DownloadFile(string URL, string filename, System.Windows.Forms.ProgressBar prog, System.Windows.Forms.Label label1)
        {
            float percent = 0;
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                    label1.Text = "正在下载更新包";
                    label2.Text = percent.ToString() + "%";
                    updateexe.Enabled = false;
                    System.Windows.Forms.Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }
                so.Close();
                st.Close();
                label1.Text = "下载完成";
                label2.Text = "";
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "update";
            if (File.Exists(Path2 + @"\" + "Hosts update.exe"))
            {
                this.Text = "正在清理中...";
                Directory.Delete(Path2, true);
                //Directory.CreateDirectory(Path2);
                MessageBox.Show("更新缓存已清理", "操作完成");
                this.Text = "更新升级";
            }
            else
            {
                MessageBox.Show("放心吧，更新缓存不存在", "没什么可以清理的");
                this.Text = "更新升级";
            }
        }
    }
}
