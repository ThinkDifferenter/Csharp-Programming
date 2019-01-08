namespace My_WindowsFormsApplication
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.点击 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // 点击
            // 
            this.点击.BackgroundImage = global::My_WindowsFormsApplication.Properties.Resources.icon011;
            this.点击.Location = new System.Drawing.Point(104, 62);
            this.点击.Name = "点击";
            this.点击.Size = new System.Drawing.Size(131, 101);
            this.点击.TabIndex = 0;
            this.点击.Text = "点击";
            this.点击.UseVisualStyleBackColor = true;
            this.点击.Click += new System.EventHandler(this.点击_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "I love program.\r\nDo you like it.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_WindowsFormsApplication.Properties.Resources._01c27c5523cc63c35797126e43f58722;
            this.ClientSize = new System.Drawing.Size(687, 395);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.点击);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 点击;
        private System.Windows.Forms.TextBox textBox1;
    }
}

