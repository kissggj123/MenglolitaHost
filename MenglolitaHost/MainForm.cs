#region CopyRight
//Host更新工具 by 北斗家老司机
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MenglolitaHost
{
    public partial class MainForm : Form
    {
        //private static String _url = "https://hosts-smounives.rhcloud.com/hosts";
        //https://coding.net/u/scaffrey/p/hosts/git/blob/master/hosts
        //https://raw.githubusercontent.com/racaljk/hosts/master/hosts
        private static String _url = "https://raw.githubusercontent.com/sy618/hosts/master/FQ";
        //https://github.com/racaljk/hosts/blob/master/hosts";
        private static String _path = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
        private Thread _thread = null;
        private System.Timers.Timer _timer = new System.Timers.Timer(40 * 1000);

        public MainForm(int _Minimum, int _Maximum)
        {
            InitializeComponent();
            progressBar1.Maximum = _Maximum;//设置范围最大值
            progressBar1.Value = progressBar1.Minimum = _Minimum;//设置范围最小值
        }

        public MainForm()
        {
            InitializeComponent();
            _timer.AutoReset = false;
            _timer.Enabled = false;
            _timer.Elapsed += TimeOut;
        }
        public void setPos(int value)//设置进度条当前进度值
        {
            if (value < progressBar1.Maximum)//如果值有效
            {
                progressBar1.Value = value;//设置进度值
            }
            Application.DoEvents();//防止父子窗体都假死
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form uphosts = new uphosts();
            uphosts.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string ico =Path + "Confion" + @"\" + "ic_launcher.ico";
            if (File.Exists(Path + "Confion" + @"\" + "newuser.use"))
            {
                step1.Visible = false;
                stepimg1.Visible = false;
                stepimg11.Visible = false;
                steptext1.Visible = false;
                stepnext1.Visible = false;
                step2.Visible = false;
                stepimg2.Visible = false;
                stepimg22.Visible = false;
                steptext2.Visible = false;
                stepnext2.Visible = false;
            }
            else
            {
                
            }

            if (File.Exists(Path + "Confion" + @"\" + "noshow.mos"))
            {
                this.ShowIcon = false;
                //this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowIcon = true;
                //this.ShowInTaskbar = true;
            }
            if (File.Exists(Path + "Confion" + @"\" + "myicon.mos"))
            {
                //
                    this.Icon = new Icon(ico);
                //
            }
            else
            {
                //this.TopMost = false;
                //this.ShowIcon = true;
                //this.ShowInTaskbar = true;
            }
            if (File.Exists(Path + "moshost.thk"))
            {
                zhuabao.Enabled = true;
                WinPcap.Enabled = true;
            }
            else
            {
                zhuabao.Enabled = false;
                WinPcap.Enabled = false;
            }
            //检测授权文件是否存在并且启用

            if (!IsAdministrator())
            {
                MessageBox.Show("请右键管理员运行", "出错了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
                Application.Exit();
            }
            else
            {
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    //System.Diagnostics.Process.Start("http://www.nvyundongxie.com/");  
                    update.Enabled = false;
                    update.Visible = false;
                    //检查是否存在hosts
                    if (File.Exists(_path))
                    {
                        //不操作
                        this.Text += "--" + "hosts更新工具";
                    }
                    else
                    {
                        string filename = _path;
                        FileStream fs = File.Create(filename);  //创建文件
                        fs.Close();
                        StreamWriter sw = new StreamWriter(filename);  //创建写入流
                        sw.Write("");
                        sw.Flush();
                        sw.Close();
                        System.IO.File.SetAttributes(_path, System.IO.FileAttributes.Normal);
                    }
                    //this.Icon=new Icon(ico);
   
                }

                MakeWriteable(_path);
            }
            MainForm MainForm = new MainForm(0, 100);
            for (int i = 0; i < 100; i++)
            {
                MainForm.setPos(i);//设置进度条位置
                timer1.Enabled = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnStartWithAdmin_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.WorkingDirectory = Application.StartupPath;
            processStartInfo.FileName = Path.GetFileName(Application.ExecutablePath);
            processStartInfo.Verb = "runas";
            string[] commandLineArgs = Environment.GetCommandLineArgs();
            if (commandLineArgs.Length > 1)
            {
                String text = "";
                for (Int32 i = 1; i < commandLineArgs.Length; i++)
                {
                    text += commandLineArgs[i];
                }
                processStartInfo.Arguments = text;
            }
            try
            {
                Process.Start(processStartInfo);
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

        private void DoUpdate()
        {
            try
            {
                this.btnUpdate.Text = "正在更新...";
                genxinhosts.Text = "正在更新hosts...";
                var req = (HttpWebRequest)WebRequest.Create(_url);
                req.ServicePoint.Expect100Continue = false;
                req.Method = "GET";
                req.KeepAlive = true;
                req.UserAgent = "Menglolita Host 1.6.7";
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
                        NativeMethods.DnsFlushResolverCache();
                        _thread = null;
                        _timer.Enabled = false;
                        this.btnUpdate.Text = "更新已结束";
                        genxinhosts.Text = "更新hosts完成";
                        MessageBox.Show("更新成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnUpdate.Enabled = true;
                    }
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "更新出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _thread = null;
                _timer.Enabled = false;
                this.btnUpdate.Text = "更新hosts";
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
                        this.btnUpdate.Text = "更新已结束";
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

        public static Boolean IsAdministrator()
        {
            Boolean result;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                WindowsIdentity current = WindowsIdentity.GetCurrent();
                WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
                result = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            else
            {
                result = true;
            }

            return result;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("MLSniffer");
            foreach (System.Diagnostics.Process p in process)
            {
                p.Kill();
            }*/
            Process[] thepro = Process.GetProcessesByName("MLSniffer");
            if (thepro.Length > 0)
            //如果进程在或者不止一个
            //变态温蒂
            {
                //逐个结束 
                for (int i = 0; i < thepro.Length; i++)
                {
                    //如果还没有结束就关闭他 
                    if (!thepro[i].CloseMainWindow()) thepro[i].Kill();
                }
            }
            //从输出流取得执行结果           
            Process[] process = Process.GetProcesses();
            foreach (Process prc in process)
            {
                Console.WriteLine(prc.ProcessName);
                if (prc.ProcessName == "MLSniffer")
                    //if (prc.ProcessName == "MLSniffer")
                    prc.Kill();
            }
            Console.ReadLine();
        }
        private static void MakeWriteable(String fileName)
        {
            if (File.Exists(fileName))
            {
                FileSystemInfo info = new FileInfo(fileName);
                if (info != null)
                    info.Attributes &= ~FileAttributes.ReadOnly;
            }
        }

        private void bakhost_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Hostbak";
            if (!System.IO.Directory.Exists(Path + @"\" + "Hostbak"))
            {
                // 目录不存在，建立目录
                System.IO.Directory.CreateDirectory(Path + @"\" + "Hostbak");
            }
            String sourcePath = Environment.SystemDirectory + "\\drivers\\etc\\hosts"; ;
            String targetPath = Path2 + @"\" + "hosts";
            bool isrewrite = true; //覆盖已存在的同名文件,false则反之
            System.IO.File.Copy(sourcePath, targetPath, isrewrite);
            MessageBox.Show("Hosts备份完成\r\n备份所在位置：" + Path2 + "\r\nHosts默认位置：C:\\Windows\\System32\\drivers\\etc", "你尽情的搞事情吧", MessageBoxButtons.OK, MessageBoxIcon.Information);
            restore.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(Path + "moshost.thk"))
            {
                //this.Text = "（" + "当前为开发者模式" + ")"; 
            }
            else
            {
                MessageBox.Show("这个功能用不了哦", "文件...好像不存在", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //启动抓包工具
            if (File.Exists(Path + "bin" + @"\" + "MLSniffer.exe"))
            {
                this.Text = "（" + "当前为开发者模式" + ")"; 
                Process proc = new Process();
                proc.StartInfo.FileName = Path + "bin" + @"\" + "MLSniffer.exe";
                proc.Start();
            }
            else
            {
                MessageBox.Show("这个功能用不了哦", "文件...好像不存在", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void qh_Click(object sender, EventArgs e)
        {
            Form aptget = new aptget();
            aptget.ShowDialog();
        }


        private void restore_Click(object sender, EventArgs e)
        {
            Form restore = new restore();
            restore.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            testhoost.Enabled = true;
            MessageBox.Show("替换功能已开启", "功能已开启", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hostlk.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感谢参与这个工具的所有人", "程序基于GPLv3协议发布", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WinPcap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            //安装WinPcap驱动用于访问底层网络
            if (File.Exists(Path + "Confion" + @"\" + "WinPcap.exe"))
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Path + "Confion" + @"\" + "WinPcap.exe";
                proc.Start();
            }
            else
            {
                MessageBox.Show("你肯定把这东西吃了", "你就等着用不了吧", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这绝对是最后一个版本\r\n不是我就是*(bi)*(bi)\r\n还有...", "说不定我马上就反悔了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menglolitaHostToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form AboutBox1 = new AboutBox1();
            AboutBox1.ShowDialog();
        }

        private void hostedit_Click(object sender, EventArgs e)
        {
            Form hostseditor = new hostseditor();
            hostseditor.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 100;
            progressBar1.Value = progressBar1.Value + 1;
            i = 100 - progressBar1.Value;
            label7.Text = "正在刷新目前可用的hosts信息";//显示百分比
            label8.Text = progressBar1.Value.ToString() + "%";
            if (i == 0)
            {
                timer1.Enabled = false;
                label7.Text = "hosts已刷新并准备就绪";//显示百分比
                label8.Text = "完成";
                //update.Enabled = true;
                //update.Visible = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
           //
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void youTube专用hostsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void goHostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Confion";
            Form gohosts = new gohosts();
            gohosts.ShowDialog();

           
        }

        private void bughosts_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Confion" + @"\" + "debug";
            if (!System.IO.Directory.Exists(Path + @"\" + "Confion"))
            {
                // 目录不存在，建立目录
                MessageBox.Show("备份的文件被你吃了嘛", "你别骗我");
                //return;
            }
            else
            {
                String oldPath = Environment.SystemDirectory + "\\drivers\\etc\\hosts"; ;
                String bakPath = Path2 + @"\" + "hosts";
                bool isrewrite = true; //覆盖已存在的同名文件,false则反之
                System.IO.File.Copy(bakPath, oldPath, isrewrite);
                MessageBox.Show("已修复不正常的hosts\n\r为保证正常使用\n\r请尽快更新为最新的hosts", "暂时帮你修复了问题", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mlHostupdate_Click(object sender, EventArgs e)
        {
            Form update = new update();
            update.ShowDialog();
        }

        private void testhoost_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog yourshosts = new OpenFileDialog();
            yourshosts.Filter = "hosts文件(hosts)|*.*";
            yourshosts.Title = "选择你要替换的hosts文件";
            yourshosts.FileName = "hosts";
            String winhosts = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            if (yourshosts.ShowDialog() == DialogResult.OK)
            {
                if (!System.IO.Directory.Exists(@"C:\\Windows\\System32\\drivers\\etc"))
                {
                    // 目录不存在，建立目录
                    System.IO.Directory.CreateDirectory(@"C:\\Windows\\System32\\drivers\\etc");
                }
                bool isrewrite = true; //覆盖已存在的同名文件,false则反之
                //System.IO.Path.Combine(@"C:\\Windows\\System32\\drivers\\etc", System.IO.Path.GetFileName(yourshosts.FileName)
                System.IO.File.Copy(yourshosts.FileName, winhosts, isrewrite);
                MessageBox.Show("hosts替换完成", "已替换", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(Path + "bin" + @"\" + "setDNS.exe"))
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Path + "bin" + @"\" + "setDNS.exe";
                proc.Start();
            }
            else
            {
                MessageBox.Show("无法进行修改DNS", "无法启动该功能", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShareX_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(Path + "bin" + @"\" + "ShareX.exe"))
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Path + "bin" + @"\" + "ShareX.exe";
                proc.Start();
            }
            else
            {
                MessageBox.Show("这是个特麻烦的问题", "反正就是无法启动", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "Confion" + @"\" + "debug";
            if (!System.IO.Directory.Exists(Path + @"\" + "Confion"))
            {
                // 目录不存在，建立目录
                MessageBox.Show("备份的文件被你吃了嘛", "你别骗我");
                //return;
            }
            else
            {
                String oldPath = Environment.SystemDirectory + "\\drivers\\etc\\hosts"; ;
                String bakPath = Path2 + @"\" + "hosts";
                bool isrewrite = true; //覆盖已存在的同名文件,false则反之
                System.IO.File.Copy(bakPath, oldPath, isrewrite);
                MessageBox.Show("已修复不正常的hosts\n\r你的hosts已经变为初始文件\n\r你也可以继续更新为最新的hosts", "暂时帮你修复了问题", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void edithosts_Click(object sender, EventArgs e)
        {
            Form hostseditor = new hostseditor();
            hostseditor.Show();
        }

        private void 更新hostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            genxinhosts.Enabled = false;
            System.IO.File.SetAttributes(_path, System.IO.FileAttributes.Normal);
            //genxinhosts.Text = "正在更新hosts...";
            if (_thread != null)
            {
                return;
            }

            _thread = new Thread(new ThreadStart(DoUpdate));
            _thread.Start();
            _timer.Enabled = true;
        }

        private void 更新dnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(Path + "bin" + @"\" + "setDNS.exe"))
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Path + "bin" + @"\" + "setDNS.exe";
                proc.Start();
            }
            else
            {
                MessageBox.Show("无法进行修改DNS", "无法启动该功能", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 偏好设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form setting = new setting();
            setting.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            step1.Visible = false;
            stepimg1.Visible = false;
            stepimg11.Visible = false;
            steptext1.Visible = false;
            stepnext1.Visible = false;
            this.tabPage2.Show();
            tabControl1.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private void stepnext2_Click(object sender, EventArgs e)
        {
            step2.Visible = false;
            stepimg2.Visible = false;
            stepimg22.Visible = false;
            steptext2.Visible = false;
            stepnext2.Visible = false;
            //完成教程
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string filename = Path + "Confion" + @"\" + "newuser.use";
            FileStream fs = File.Create(filename);  //创建文件
            fs.Close();
            StreamWriter sw = new StreamWriter(filename);  //创建写入流
            sw.Write("感谢使用Menglolita Host更新工具" + "{" + "已完成教程" + "}");
            sw.Flush();
            sw.Close();
            //显示更新窗体
            Form uphosts = new uphosts();
            uphosts.Show();
        }

        private void 更新修复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form update = new update();
            update.Show();
        }
    }
        }
//更新于2017-5-14 21:46:17
        
 
    


