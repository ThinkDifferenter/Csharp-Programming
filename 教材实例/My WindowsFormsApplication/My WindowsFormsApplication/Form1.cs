using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_WindowsFormsApplication
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

        private void 点击_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            MessageBox.Show("My name is jiangjun");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ;
        }
    }
}
