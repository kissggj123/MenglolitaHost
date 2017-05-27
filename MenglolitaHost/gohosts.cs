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
    public partial class gohosts : Form
    {
        private static String gohost = "https://raw.githubusercontent.com/Lerist/Go-Hosts/master/hosts";
        private static String gohostad = "https://raw.githubusercontent.com/Lerist/Go-Hosts/master/hosts-ad";
        private static String _path = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
        private Thread _thread = null;
        private System.Timers.Timer _timer = new System.Timers.Timer(40 * 1000);
        public gohosts()
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
                var req = (HttpWebRequest)WebRequest.Create(gohost);
                req.ServicePoint.Expect100Continue = false;
                req.Method = "GET";
                req.KeepAlive = true;
                req.UserAgent = "Menglolita Host 1.6.8";
                req.Timeout = 30 * 1000;

                // 以字符流的方式读取HTTP响应
                using (var rsp = (HttpWebResponse)req.GetResponse())
                {
                    var encoding = Encoding.GetEncoding(rsp.CharacterSet);
                    using (var stream = rsp.GetResponseStream())
                    using (var reader = new StreamReader(stream, encoding))
                    {
                        var content = reader.ReadToEnd();
                        System.IO.File.SetAttributes(_path, System.IO.FileAttributes.Normal);
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
                        gohostdefault.Enabled = true;
                        gohostnoad.Enabled = true;
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
                this.progress.Text = "点击可再次更新hosts";
            }
        }

        void TimeOut(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (_thread != null && _thread.IsAlive)
            {
                if (MessageBox.Show("看起来超时了！是否终止！", "你不要搞事情", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
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

        private void DoUpdatenoad()
        {
            try
            {
                this.progress.Text = "正在更新...";
                var req = (HttpWebRequest)WebRequest.Create(gohostad);
                req.ServicePoint.Expect100Continue = false;
                req.Method = "GET";
                req.KeepAlive = true;
                req.UserAgent = "Menglolita Host 1.6.8";
                req.Timeout = 30 * 1000;

                // 以字符流的方式读取HTTP响应
                using (var rsp = (HttpWebResponse)req.GetResponse())
                {
                    var encoding = Encoding.GetEncoding(rsp.CharacterSet);
                    using (var stream = rsp.GetResponseStream())
                    using (var reader = new StreamReader(stream, encoding))
                    {
                        var content = reader.ReadToEnd();
                        System.IO.File.SetAttributes(_path, System.IO.FileAttributes.Normal);
                        File.WriteAllText(_path, content, Encoding.UTF8);
                        //更新DNS缓存
                        NativeMethods.DnsFlushResolverCache();
                        _thread = null;
                        _timer.Enabled = false;
                        this.progress.Text = "更新已结束";
                        MessageBox.Show("更新成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gohostdefault.Enabled = true;
                        gohostnoad.Enabled = true;
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
                this.progress.Text = "点击可再次更新hosts";
            }
        }


        private void gohosts_Load(object sender, EventArgs e)
        {

        }

        private void gohostdefault_CheckedChanged(object sender, EventArgs e)
        {
            gohostdefault.Enabled = false;
            gohostnoad.Enabled = false;
            System.IO.File.SetAttributes(_path, System.IO.FileAttributes.Normal);
            //safe.Enabled = 被禁止;
            if (_thread != null)
            {
                return;
            }

            _thread = new Thread(new ThreadStart(DoUpdate));
            _thread.Start();
            _timer.Enabled = true;
        }

        private void gohostnoad_CheckedChanged(object sender, EventArgs e)
        {
            gohostdefault.Enabled = false;
            gohostnoad.Enabled = false;
            System.IO.File.SetAttributes(_path, System.IO.FileAttributes.Normal);
            //safe.Enabled = 被禁止;
            if (_thread != null)
            {
                return;
            }

            _thread = new Thread(new ThreadStart(DoUpdatenoad));
            _thread.Start();
            _timer.Enabled = true;
        }
        }
    }
