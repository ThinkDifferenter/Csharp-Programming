using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否看到窗体?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭窗体", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
            MessageBox.Show("My name is jiangjun");
        }
    }
}
