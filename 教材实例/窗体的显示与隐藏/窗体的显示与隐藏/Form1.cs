using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 窗体的显示与隐藏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form();
            Form2.Hide();
            MessageBox.Show("我隐藏了窗体!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ("窗体的显示与隐藏");
            label1.Visible = true;
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了窗体!");
        }
    }
}
