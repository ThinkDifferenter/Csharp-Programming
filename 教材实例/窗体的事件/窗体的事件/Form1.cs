using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 窗体的事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否看到了窗体?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("看到窗体就对了!");
            }
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了窗体，触发了窗体事件！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("窗体事件触发");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "窗体事件";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭窗体?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
            //FormClosed 是窗体关闭后才触发的事件
            //FormClosing 是窗体关闭过程中触发的事件
        }
    
    }
}
