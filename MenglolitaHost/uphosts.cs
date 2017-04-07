using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MenglolitaHost
{
    public partial class uphosts : Form
    {
         //private static String _url = "https://hosts-smounives.rhcloud.com/hosts";
        //https://coding.net/u/scaffrey/p/hosts/git/blob/master/hosts
        //https://raw.githubusercontent.com/racaljk/hosts/master/hosts
        //private static String _url = "https://raw.githubusercontent.com/racaljk/hosts/master/hosts";
        private static String _url = "https://raw.githubusercontent.com/sy618/hosts/master/FQ";
        //https://github.com/racaljk/hosts/blob/master/hosts";
        private static String _path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        private Thread _thread = null;
        private System.Timers.Timer _timer = new System.Timers.Timer(40 * 1000);

        public uphosts()
        {
            InitializeComponent();
             _timer.AutoReset = false;
            _timer.Enabled = false;
            _timer.Elapsed += TimeOut;
        }

        private void DoUpdate()
        {
            try
            {
                this.progress.Text = "正在更新...";
                var req = (HttpWebRequest)WebRequest.Create(_url);
                req.ServicePoint.Expect100Continue = false;
                req.Method = "GET";
                req.KeepAlive = true;
                req.UserAgent = "Menglolita Host 1.5.8";
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
                        //更新DNS缓存
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
                        //p.StandardInput.WriteLine("exit");
                        _thread = null;
                        _timer.Enabled = false;
                        this.progress.Text = "更新已结束";
                        MessageBox.Show("更新成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        zhenchang.Enabled = true;
                    }
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "更新出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _thread = null;
                _timer.Enabled = false;
                this.progress.Text = "更新hosts";
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
                        this.progress.Text = "更新已结束";
                        _thread = null;
                        _timer.Enabled = false;
                        _thread.Abort();
                        //this.SafeInvoke(() => { this.btnUpdate.Text = "更新已结束"; });
                    }
                    catch { }
                }
                else
                {
                    _timer.Start();
                }
            }
        }

        private void yhost_CheckedChanged(object sender, EventArgs e)
        {
            zhenchang.Enabled = false;
            safe.Enabled = true;
            if (_thread != null)
            {
                return;
            }

            _thread = new Thread(new ThreadStart(DoUpdate));
            _thread.Start();
            _timer.Enabled = true;
        }

        private void progress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击上面的2个选项即可开始更新", "你操作方式不对", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void safe_CheckedChanged(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            safe.Enabled = false;
            Process proc = new Process();
            proc.StartInfo.FileName = Path + "bin" + @"\" + "sfmd.exe";
            proc.Start();
            progress.Text = "请在右下角寻找图标并等待完成\r\n你也可以随时关闭该窗口";
        }

        private void uphosts_Load(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(Path + "bin" + @"\" + "sfmd.exe"))
            {
                safe.Enabled = true;
                //Process proc = new Process();
                //proc.StartInfo.FileName = Path + "bin" + @"\" + "sfmd.exe";
                //proc.Start();
                //progress.Text = "已开启安全更新，请在右下角寻找图标并等待完成";
            }
            else
            {
                MessageBox.Show("安全模式无法启动", "安全模式被禁止使用", MessageBoxButtons.OK, MessageBoxIcon.Information);
                safe.Enabled = false;
            }
        }
    }
}
