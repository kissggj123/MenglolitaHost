using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenglolitaHost
{
    public partial class easymode : Form
    {
        public easymode()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox1.Checked = true;
            checkBox2.Enabled = true;
            checkBox2.Checked = true;
            qd.Enabled = true;
            qd.Text = "开始更新";
        }

        private void qd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("需要再等等", "还没完成");
        }
    }
}
