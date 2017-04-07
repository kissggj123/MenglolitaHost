using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace MenglolitaHost
{
    public partial class moreapt : Form
    {
        private static String _path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        private Thread _thread = null;
        private System.Timers.Timer _timer = new System.Timers.Timer(40 * 1000);
        public moreapt()
        {
            InitializeComponent();
            _timer.AutoReset = false;
            _timer.Enabled = false;
            _timer.Elapsed += TimeOut;
        }

        private void moreapt_Load(object sender, EventArgs e)
        {
            yourshostsupdate.Enabled = false;
        }

        private void yourshostsupdate_Click(object sender, EventArgs e)
        {
            yourshostsurl.ReadOnly = true;
            yourshostsupdate.Enabled = false;
            //写入文件
            string filename = "yoursapt.txt";
            string word = yourshostsurl.Text;
            FileStream fs = File.Create(filename);  //创建文件
            fs.Close();
            StreamWriter sw = new StreamWriter(filename);  //创建写入流
            sw.Write("你最后一次更新的hosts源是" + "{" + word + "}");
            sw.Flush();
            sw.Close();
            //url ReadOnly
            //update Enabled
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path3 = AppDomain.CurrentDomain.BaseDirectory + "temp";
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak" + @"\" + "自定义源hosts备份";
            if (!System.IO.Directory.Exists(Path + @"\" + "Hostbak" + @"\" + "自定义源hosts备份"))
            {
                // 目录不存在，建立目录
                System.IO.Directory.CreateDirectory(Path + @"\" + "Hostbak" + @"\" + "自定义源hosts备份");
            }
            if (!System.IO.Directory.Exists(Path3))
            {
                // 目录不存在，建立目录
                System.IO.Directory.CreateDirectory(Path3);
            }
            String sourcePath = "C:\\Windows\\System32\\drivers\\etc\\hosts"; 
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
            string Path3 = AppDomain.CurrentDomain.BaseDirectory+"temp";
            string apturl = yourshostsurl.Text;
            try
            {
                this.yourshostsupdate.Text = "正在更新...";
                var req = (HttpWebRequest)WebRequest.Create(apturl);
                req.ServicePoint.Expect100Continue = false;
                req.Method = "GET";
                req.KeepAlive = true;
                req.UserAgent = "Menglolita Host 1.3";
                //req  
                req.Timeout = 30 * 1000;

                // 以字符流的方式读取HTTP响应
                using (var rsp = (HttpWebResponse)req.GetResponse())
                {
                    var encoding = Encoding.GetEncoding(rsp.CharacterSet);
                    using (var stream = rsp.GetResponseStream())
                    using (var reader = new StreamReader(stream, encoding))
                    {
                        var content = reader.ReadToEnd();
                        File.WriteAllText(Path3 + @"\" + "hosts", content, Encoding.UTF8);
                        /*if (!System.IO.Directory.Exists(Path3))
                        {
                            // 目录不存在，建立目录
                            System.IO.Directory.CreateDirectory(Path3);
                        }*/
                        if (File.Exists(Path3+ @"\"+"hosts"))
                        {

                            // 文件存在
                            String sourcePath = "C:\\Windows\\System32\\drivers\\etc\\hosts"; ;
                            String targetPath = Path3 + @"\" + "hosts";
                            bool isrewrite = true; //覆盖已存在的同名文件,false则反之
                            System.IO.File.Copy(sourcePath, targetPath, isrewrite);
                            Directory.Delete(Path3, true);
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
                            //Directory.CreateDirectory(Path3);
                            _thread = null;
                            _timer.Enabled = false;
                            this.yourshostsupdate.Text = "更新已结束";
                            MessageBox.Show("更新自定义源hosts成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("这个源好像不支持哦", "重新换个源吧", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //文件不存在
                        }
                        //更新成功
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
                        string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak" + @"\" + "自定义源hosts备份";
                        MessageBox.Show("你的Host也已进行了备份\r\n备份所在位置：" + Path2 + "\r\nHosts默认位置：C:\\Windows\\System32\\drivers\\etc\r\n你可以通过主界面恢复选项进行hosts恢复", "你尽情的搞事情吧",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        yourshostsupdate.Enabled = false;
                        yourshostsurl.Text = "";
                        yourshostsurl.ReadOnly = false;
                        //this.Close();
                    }
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "这个源好像不支持哦", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _thread = null;
                _timer.Enabled = false;
                yourshostsurl.ReadOnly = false;
                this.yourshostsupdate.Text = "开始更新"; 
            }
        }


        void TimeOut(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (_thread != null && _thread.IsAlive)
            {
                if (MessageBox.Show("TM！这个源看起来好像不支持！是否终止！", "你不要搞事情", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        this.yourshostsupdate.Text = "更新已结束";
                        _thread.Abort();
                        yourshostsurl.ReadOnly = false;
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

        private void yourshostsurl_TextChanged(object sender, EventArgs e)
        {
            //string Standardm = "0"; //初始化一个变量
            //Standardm = this.yourshostsurl.Text.Trim();//文本框内容赋值给变量
            //Regex digitregex = new Regex(@"https://github.com\dhttps://raw.githubusercontent.com");//初始化正则表达式
            //if (digitregex.IsMatch(Standardm) == false)
            //if(yourshostsurl.Text.Trim()==" "）
            //判断文本框内容是否符合正则表达式
            if (yourshostsurl.Text.Trim() == String.Empty)
            {
                yourshostsupdate.Enabled = false;
            }
            else
            {
                //MessageBox.Show("这个源好像不支持哦", "重新换个源吧", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yourshostsupdate.Enabled = true;
                //yourshostsurl.Text = "";
            }
        }
    }
}
    
            

