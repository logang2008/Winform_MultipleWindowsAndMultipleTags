using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form100 : Form
    {
        private int index = 0;  
        public Form100()
        {
            InitializeComponent();
        }

        private void Form100_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                TabPage Page = new TabPage();
                Page.Name = "Page" + i.ToString();
                Page.Text = "tabPage" + i.ToString();
                Button t = new Button()
                {
                    Text = "aa"+i.ToString()
                };
                Page.Controls.Add(t);
                this.tabControl1.Controls.Add(Page);
            }
            this.tabControl1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage Page = new TabPage();
            Page.Name = "Page" + index.ToString();
            Page.Text = "tabPage" + index.ToString();
            Page.TabIndex = index;
            this.tabControl1.Controls.Add(Page);

            #region 三种设置某个选项卡为当前选项卡的方法
            //this.tabControl1.SelectedIndex = index;  
            this.tabControl1.SelectedTab = Page;
            //this.tabControl1.SelectTab("Page" + index.ToString());  
            #endregion

            index++;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool first = true;
            if (index > 0)
            {
                #region 两种删除某个选项卡的方法
                this.tabControl1.Controls.RemoveAt(this.tabControl1.SelectedIndex);
                //this.tabControl1.Controls.Remove(this.tabControl1.TabPages[this.tabControl1.TabPages.Count-1]);  
                #endregion
            }
            else
            {
                return;
            }

            #region 用于设置删除最后一个TabPage后，将倒数第二个设置为当前选项卡
            if (first)
            {
                this.tabControl1.SelectedIndex = --index - 1;
                first = false;
            }
            else
            {
                this.tabControl1.SelectedIndex = index--;
            }
            #endregion   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab.Text = "xyt";//修改当前选项卡的属性  
            //this.tabControl1.SelectedTab.Name = "";  
            //this.tabControl1.SelectedTab.Tag = "";  
            //this.tabControl1.SelectedTab.Select(); 
        }
    }
}
