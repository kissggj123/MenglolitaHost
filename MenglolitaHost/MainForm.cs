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
        private static String _url = "https://raw.githubusercontent.com/racaljk/hosts/master/hosts";
        //https://github.com/racaljk/hosts/blob/master/hosts";
        private static String _path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        private Thread _thread = null;
        private System.Timers.Timer _timer = new System.Timers.Timer(40 * 1000);

        public MainForm()
        {
            InitializeComponent();
            _timer.AutoReset = false;
            _timer.Enabled = false;
            _timer.Elapsed += TimeOut;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            if (_thread != null)
            {
                return;
            }

            _thread = new Thread(new ThreadStart(DoUpdate));
            _thread.Start();
            _timer.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                MessageBox.Show("请右键管理员运行", "出错了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //panelUAC.Dock = DockStyle.Fill;
                //panelUAC.BringToFront();
                //panelUAC.Visible = true;
                Application.Exit();
            }
            else
            {
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    this.Text += "--"+"by 北斗家老司机";
                }

                MakeWriteable(_path);
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
                this.SafeInvoke(() => { this.btnUpdate.Text = "正在更新..."; });
                var req = (HttpWebRequest)WebRequest.Create(_url);
                req.ServicePoint.Expect100Continue = false;
                req.Method = "GET";
                req.KeepAlive = true;
                req.UserAgent = "Menglolita Host 1.0";
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
                        MessageBox.Show("更新成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnUpdate.Enabled = true;
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
                this.SafeInvoke(() => { this.btnUpdate.Text = "已经好啦"; });
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
                        this.SafeInvoke(() => { this.btnUpdate.Text = "更新到最新"; });
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
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + @"\" + "Hostbak";
            if (!System.IO.Directory.Exists(Path+@"\"+"Hostbak"))
            {
                // 目录不存在，建立目录
                System.IO.Directory.CreateDirectory(Path + @"\" + "Hostbak");
            }
            String sourcePath = "C:\\Windows\\System32\\drivers\\etc\\hosts"; ;
            String targetPath = Path2+@"\"+"hosts";
            bool isrewrite = true; //覆盖已存在的同名文件,false则反之
            System.IO.File.Copy(sourcePath, targetPath, isrewrite);
            MessageBox.Show("Host备份完成", "你尽情的搞事情吧");

        }
    }

    public static class ControlExtention
    {
        public delegate void InvokeHandler();

        public static void SafeInvoke(this Control control, InvokeHandler handler)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(handler);
            }
            else
            {
                handler();
            }
        }
    }
}
