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
    public partial class hostseditor : Form
    {
        public hostseditor()
        {
            InitializeComponent();
        }

        private void 打开hostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String hostspath = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            richTextBox1.Text = File.ReadAllText(hostspath, Encoding.Default);
            savehosts.Enabled = true;
        }

        private void 写入hostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String hostspath = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            richTextBox1.SaveFile(hostspath, RichTextBoxStreamType.PlainText);
            MessageBox.Show("写入完成", "已完成自定义编辑", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hostseditor_Load(object sender, EventArgs e)
        {
            savehosts.Enabled = false;
        }
    }
}
