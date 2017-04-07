using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MenglolitaHost
{
    public partial class aptget : Form
    {
        //private static String _url = "https://hosts-smounives.rhcloud.com/hosts";
        //https://coding.net/u/scaffrey/p/hosts/git/blob/master/hosts
        //https://raw.githubusercontent.com/racaljk/hosts/master/hosts
        //private static String _url = "https://raw.githubusercontent.com/racaljk/hosts/master/hosts";
        //https://github.com/racaljk/hosts/blob/master/hosts";
        private static String _path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        private Thread _thread = null;
        private System.Timers.Timer _timer = new System.Timers.Timer(40 * 1000);
        public aptget()
        {
            InitializeComponent();
            _timer.AutoReset = false;
            _timer.Enabled = false;
            _timer.Elapsed += TimeOut;
        }

        private void aptget_Load(object sender, EventArgs e)
        {
            //comboBox1ItemIndex = 0
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(Path + "moshost.thk"))
            {
                moreapt.Visible = true;
                moreapt.Enabled = true;
                ipv6hosts.Enabled = true;
                //
            }
            else
            {
                moreapt.Visible = false;
                moreapt.Enabled = false;
                ipv6hosts.Enabled = false;
                //
            }
            url.Visible = false;
            yhost.Checked = false;
            adfqhosts.Checked = false;
            twotoone.Checked = false;
            qd.Enabled = false;
        }

        private void qd_Click(object sender, EventArgs e)
        {
            string filename = "aptget";
            string word = "你已使用第三方源的host";
            FileStream fs = File.Create(filename);  //创建文件
            fs.Close();
            StreamWriter sw = new StreamWriter(filename);  //创建写入流
            sw.Write("apt is" + "{" + word + "}");
            sw.Flush();
            sw.Close();
            //this.Close();
            qd.Enabled = false;
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak" + @"\" + "第三方源hosts备份";
            if (!System.IO.Directory.Exists(Path + @"\" + "Hostbak" + @"\" + "第三方源hosts备份"))
            {
                // 目录不存在，建立目录
                System.IO.Directory.CreateDirectory(Path + @"\" + "Hostbak" + @"\" + "第三方源hosts备份");
            }
            String sourcePath = "C:\\Windows\\System32\\drivers\\etc\\hosts"; ;
            String targetPath = Path2 + @"\" + "hosts";
            bool isrewrite = true; //覆盖已存在的同名文件,false则反之
            System.IO.File.Copy(sourcePath, targetPath, isrewrite);
            if (_thread != null)
            {
                return;
            }

            _thread = new Thread(new ThreadStart(DoUpdate));
            _thread.Start();
            _timer.Enabled = true;
        }

        private void DoUpdate()
        {
            string apturl = url.Text;
            try
            {
               this.qd.Text = "正在更新...";
                var req = (HttpWebRequest)WebRequest.Create(apturl);
                req.ServicePoint.Expect100Continue = false;
                req.Method = "GET";
                req.KeepAlive = true;
                req.UserAgent = "Menglolita Host 1.3";
                req.Timeout = 30 * 1000;

                // 以字符流的方式读取HTTP响应
                using (var rsp = (HttpWebResponse)req.GetResponse())
                {
                    var encoding = Encoding.GetEncoding(rsp.CharacterSet);
                    using (var stream = rsp.GetResponseStream())
                    using (var reader = new StreamReader(stream, encoding))
                    {
                        var content = reader.ReadToEnd();
                        File.WriteAllText(_path, content, Encoding.UTF8);
                        string str = "ipconfig /flushdns";
                        System.Diagnostics.Process p = new System.Diagnostics.Process(); p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动
                        p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                        p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                        p.StartInfo.RedirectStandardError = true;//重定向标准错误输出 
                        p.StartInfo.CreateNoWindow = true;//不显示程序窗口
                        p.Start();//启动程序
                        //向cmd窗口发送输入信息
                        p.StandardInput.WriteLine(str + "&exit");
                        p.StandardInput.AutoFlush = true;
                        _thread = null;
                        _timer.Enabled = false;
                        this.qd.Text = "更新已结束"; 
                        MessageBox.Show("更新第三方源成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak" + @"\" + "第三方源hosts备份";
                        /*string Path = AppDomain.CurrentDomain.BaseDirectory;
                        string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak" + @"\" + "第三方源hosts备份";
                        if (!System.IO.Directory.Exists(Path + @"\" + "Hostbak" + @"\" + "第三方源hosts备份"))
                        {
                            // 目录不存在，建立目录
                            System.IO.Directory.CreateDirectory(Path + @"\" + "Hostbak" + @"\" + "第三方源hosts备份");
                        }
                        String sourcePath = "C:\\Windows\\System32\\drivers\\etc\\hosts"; ;
                        String targetPath = Path2 + @"\" + "hosts";
                        bool isrewrite = true; //覆盖已存在的同名文件,false则反之
                        System.IO.File.Copy(sourcePath, targetPath, isrewrite);*/
                        string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak" + @"\" + "第三方源hosts备份";
                        MessageBox.Show("你的Host也已进行了备份\r\n备份所在位置：" + Path2 + "\r\nHosts默认位置：C:\\Windows\\System32\\drivers\\etc\r\n你可以通过主界面恢复选项进行hosts恢复", "你尽情的搞事情吧", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        qd.Enabled = true;
                        //this.Close();
                    }
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TM出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _thread = null;
                _timer.Enabled = false;
                this.qd.Text = "开始更新"; 
            }
        }

       
        void TimeOut(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (_thread != null && _thread.IsAlive)
            {
                if (MessageBox.Show("TM！看起来超时了！是否终止！", "你不要搞事情", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        this.qd.Text = "更新已结束"; 
                        _thread.Abort();
                    }
                    catch { }
                }
                else
                {
                    _timer.Start();
                }
            }
        }


        private void aptget_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_thread != null && _thread.IsAlive)
            {
                try
                {
                    _thread.Abort();
                }
                catch { }
            }
        }

       

        private void adfqhosts_CheckedChanged(object sender, EventArgs e)
        {
            //apt地址
            if (adfqhosts.Checked)
                url.Text = "https://raw.githubusercontent.com/racaljk/hosts/master/hosts";
                qd.Enabled = true;
        }

        private void twotoone_CheckedChanged(object sender, EventArgs e)
        {
            //apt地址
            if (twotoone.Checked)
                url.Text = "https://raw.githubusercontent.com/sy618/hosts/master/ADFQ";
                qd.Enabled = true;
        }

        private void yhost_CheckedChanged(object sender, EventArgs e)
        {
            //apt地址
            if (yhost.Checked)
                url.Text = "https://raw.githubusercontent.com/vokins/yhosts/master/hosts";
                qd.Enabled = true;
        }

        private void moreapt_Click(object sender, EventArgs e)
        {
            Form moreapt = new moreapt();
            moreapt.ShowDialog();
        }

        private void ipv6hosts_CheckedChanged(object sender, EventArgs e)
        {
            if (ipv6hosts.Checked)
                url.Text = "https://raw.githubusercontent.com/lennylxx/ipv6-hosts/master/hosts";
            qd.Enabled = true;
        }
    }
}
