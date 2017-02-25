namespace WindowsFormsApplication2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Form2 = new System.Windows.Forms.TabPage();
            this.Form3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Form2);
            this.tabControl1.Controls.Add(this.Form3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 570);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.Form2.Location = new System.Drawing.Point(4, 22);
            this.Form2.Name = "Form2";
            this.Form2.Padding = new System.Windows.Forms.Padding(3);
            this.Form2.Size = new System.Drawing.Size(523, 373);
            this.Form2.TabIndex = 0;
            this.Form2.Tag = "WindowsFormsApplication2.Form2";
            this.Form2.Text = "Form2";
            this.Form2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.Form3.Location = new System.Drawing.Point(4, 22);
            this.Form3.Name = "Form3";
            this.Form3.Padding = new System.Windows.Forms.Padding(3);
            this.Form3.Size = new System.Drawing.Size(839, 544);
            this.Form3.TabIndex = 1;
            this.Form3.Tag = "WindowsFormsApplication2.Form3";
            this.Form3.Text = "Form3";
            this.Form3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Form2;
        private System.Windows.Forms.TabPage Form3;
    }
}

