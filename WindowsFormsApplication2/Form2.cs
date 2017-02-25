using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IFlight.Ticket.Common.Util;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Loadmm(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                initTabPage(i);
            }
            this.frm2TabControl1.SelectedIndex = 0;
        }

        private void initTabPage(int i)
        {
            TabPage Page = new TabPage();
            Page.Name = "Page" + i.ToString();
            Page.Text = "tabPage" + i.ToString();
            #region 开启按钮
            Button btnStartup = new Button()
            {
                Text = "开启",
                Name = "btnStartup" + i.ToString(),
                Width = 200,
                Location = new Point() { X = 0, Y = 450 },

            };
            btnStartup.Click += new EventHandler(btnStartups_Click);//添加点击事件
            #endregion
            #region 关闭按钮
            Button btnShutdown = new Button()
            {
                Text = "关闭",
                Name = "btnShutdown" + i.ToString(),
                Width = 80,
                Location = new Point() { X = 220, Y = 450 },

            };
            btnShutdown.Click += new EventHandler(btnShutdowns_Click);//添加点击事件
            #endregion
            #region 新增加按钮
            Button btnAdduser = new Button()
            {
                Text = "新增用户",
                Name = "btnAdduser" + i.ToString(),
                Width = 120,
                Location = new Point() { X = 320, Y = 450 },

            };
            btnAdduser.Click += new EventHandler(btnAddusers_Click);//添加点击事件
            #endregion
            DataGridView dv = refleshGird(i);
            Page.Controls.Add(btnStartup);
            Page.Controls.Add(btnShutdown);
            Page.Controls.Add(btnAdduser);
            Page.Controls.Add(dv);
            this.frm2TabControl1.Controls.Add(Page);
        }
        private DataGridView refleshGird(int i)
        {
            DataGridView dv = new DataGridView()
            {
                Name = "dv" + i.ToString(),
                Size = new Size() { Height = 400, Width = 800 },
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            };
            dv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Topic",
                HeaderText = "Topic",
                Width = 150,
            });
            dv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                HeaderText = "Status",
                Width = 100,
            });
            dv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Item",
                HeaderText = "Item",
                Width = 450,

            });
            for (int j = 0; j < 8; j++)
            {
                string itemContent = string.Empty;
                for (int m = 0; m < 5; m++)
                {
                    itemContent += i.ToString() + RandomHelper.GetRandomString(5 + m).PadRight(20, ' ') + " ";
                    itemContent += i.ToString() + RandomHelper.GetRandomString(10 + m).PadRight(25, ' ') + " ";
                    itemContent += i.ToString() + RandomHelper.GetRandomString(15 + m).PadRight(30, ' ');
                    if (m < 5 - 1)
                    {
                        itemContent += "\r\n";
                    }
                }
                dv.Rows.Add("中国" + (j + 1), "北京" + j, itemContent);
            }
            return dv;

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = this.frm2TabControl1.SelectedIndex.ToString();
            TabPage tabCurrent = ((TabPage)(this.frm2TabControl1.Controls.Find("Page" + index, false)[0]));
            ((Button)(tabCurrent.Controls.Find("btnStartup" + index, false)[0])).Text = "开启 Current " + index;
            DataGridView dvCurrent = ((DataGridView)(tabCurrent.Controls.Find("dv" + index, false)[0]));
            tabCurrent.Controls.Remove(dvCurrent);
            int i = int.Parse(index);

            DataGridView dv = refleshGird(i);
            tabCurrent.Controls.Add(dv);
        }
        void btnStartups_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            string index = but.Name.Replace("btnStartup", "").ToString();
            TabPage tabCurrent = ((TabPage)(this.frm2TabControl1.Controls.Find("Page" + index, false)[0]));
            DataGridView dvCurrent = ((DataGridView)(tabCurrent.Controls.Find("dv" + index, false)[0]));
            dvCurrent.CurrentRow.Cells["Status"].Value = "true";
        }
        void btnShutdowns_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            string index = but.Name.Replace("btnShutdown", "").ToString();
            TabPage tabCurrent = ((TabPage)(this.frm2TabControl1.Controls.Find("Page" + index, false)[0]));
            DataGridView dvCurrent = ((DataGridView)(tabCurrent.Controls.Find("dv" + index, false)[0]));
            dvCurrent.CurrentRow.Cells["Status"].Value = "false";
        }

        void btnAddusers_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            string index = but.Name.Replace("btnAdduser", "").ToString();
            TabPage tabCurrent = ((TabPage)(this.frm2TabControl1.Controls.Find("Page" + index, false)[0]));
            DataGridView dvCurrent = ((DataGridView)(tabCurrent.Controls.Find("dv" + index, false)[0]));
            int i = 0;
            foreach(Control ctrl in this.frm2TabControl1.Controls){
                if (ctrl.GetType() == tabCurrent.GetType())
                {
                    i += 1;
                }
            }
            initTabPage(i);
            this.frm2TabControl1.SelectedIndex = i;
        }
    }
}
