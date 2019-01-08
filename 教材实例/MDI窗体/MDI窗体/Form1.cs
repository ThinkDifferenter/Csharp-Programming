using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "MDI窗体";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            this.CancelButton = button1;

            if (MessageBox.Show("是否看到了窗体?", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
            {

            }
            Form form2 = new Form();
            form2.MdiParent = this;
            form2.Show();
            Form form3 = new Form();
            form3.MdiParent = this;
            form3.Show();
            Form form4 = new Form();
            form4.MdiParent = this;
            form4.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了窗体!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭窗体", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            MessageBox.Show("水平平铺");
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            MessageBox.Show("垂直平铺");
        }

        private void 层叠排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
            MessageBox.Show("层叠排列");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按钮控件触发!");
        }

    }
}