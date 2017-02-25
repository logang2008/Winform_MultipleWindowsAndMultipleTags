using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;  

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public int[] s = { 0, 0 };         //用来记录from是否打开过  

        public Form1()
        {
            InitializeComponent();            //初始打开时就加载Form2  
            string formClass = "WindowsFormsApplication2.Form2";
            GenerateForm(formClass, tabControl1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s[tabControl1.SelectedIndex] == 0)    //只生成一次  
            {
                btnX_Click(sender, e);
            }
        }

        /// <summary>  
        /// 通用按钮点击选项卡 在选项卡上显示对应的窗体  
        /// </summary>  
        private void btnX_Click(object sender, EventArgs e)
        {
            string formClass = ((TabControl)sender).SelectedTab.Tag.ToString();

            //string form = tabControl1.SelectedTab.Tag.ToString();  

            GenerateForm(formClass, sender);

        }


        //在选项卡中生成窗体  
        public void GenerateForm(string form, object sender)
        {
            // 反射生成窗体  
            Form fm = (Form)Assembly.GetExecutingAssembly().CreateInstance(form);

            //设置窗体没有边框 加入到选项卡中  
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.TopLevel = false;
            fm.Parent = ((TabControl)sender).SelectedTab;
            fm.ControlBox = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            s[((TabControl)sender).SelectedIndex] = 1;

        }
    }  
}
