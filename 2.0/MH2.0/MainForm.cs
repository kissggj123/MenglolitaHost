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
        //private static String _url = "https://raw.githubusercontent.com/racaljk/hosts/master/hosts";
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
        }
        public void setPos(int value)//设置进度条当前进度值
        {
            if (value < progressBar1.Maximum)//如果值有效
            {
                progressBar1.Value = value;//设置进度值
            }
            Application.DoEvents();//防止父子窗体都假死
        }

        /*private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            if (_thread != null)
            {
                return;
            }

            _thread = new Thread(new ThreadStart(DoUpdate));
            _thread.Start();
            _timer.Enabled = true;
        }*/

        private void MainForm_Load(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            /*if (Directory.Exists(Path + @"\" + "yoursHosts"))
            {
                testhoost.Enabled = true;
                hostlk.Enabled = false;
            }
            else
            {
                testhoost.Enabled = false;
                hostlk.Enabled = true;
            }

            if (Directory.Exists(Path + @"\" + "Hostbak"))
            {
                restore.Enabled = true;
            }
            else
            {
                restore.Enabled = true;
            }*/

            if (File.Exists(Path + "moshost.thk"))
            {
                //zhuabao.Enabled = true;
                //WinPcap.Enabled = true;
            }
            else
            {
                //zhuabao.Enabled = false;
                //WinPcap.Enabled = false;
            }
            //检测授权文件是否存在并且启用

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
                    update.Enabled = false;
                    update.Visible = false;
                    this.Text += "--" + "简单的科学上网工具";
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
            //如果进程曾在或者不止一个 
            {
                //逐个结束 
                for (int i = 0; i < thepro.Length; i++)
                {
                    //如果还没有结束就关闭他 
                    if (!thepro[i].CloseMainWindow()) thepro[i].Kill();
                }
            }
            //從輸出流取得命令執行結果
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
            MessageBox.Show("这TM绝对是最后一个版本\r\n不是我就是*(bi)*(bi)\r\n还有...", "说不定我马上就反悔了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menglolitaHostToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form AboutBox1 = new AboutBox1();
            AboutBox1.ShowDialog();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 100;
            progressBar1.Value = progressBar1.Value + 1;
            i = 100 - progressBar1.Value;
            label7.Text = "正在进行一些准备工作";//显示百分比
            label8.Text = progressBar1.Value.ToString() + "%";
            if (i == 0)
            {
                timer1.Enabled = false;
                label7.Text = "配置完成并准备就绪";//显示百分比
                label8.Text = "完成";
                //update.Enabled = true;
                //update.Visible = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            /*timer1.Enabled = true;
            update.Enabled = false;
            update.Visible = false;
            int i = 100;
            progressBar1.Value = progressBar1.Value + 1;
            i = 100 - progressBar1.Value;
            label7.Text = "正在重新检查程序源的hosts信息";//显示百分比
            label8.Text = progressBar1.Value.ToString() + "%";
            if (i == 0)
            {
                timer1.Enabled = false;
                label7.Text = "hosts源已准备就绪";//显示百分比
                label8.Text = "完成";
                update.Enabled = true;
                update.Visible = true;*/
        }


        private void mlHostupdate_Click(object sender, EventArgs e)
        {
            Form update = new update();
            update.ShowDialog();
        }
    }
}

       



    

        /*public static class ControlExtention
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
}*/
        
 
    


