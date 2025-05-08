using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SMManagerDemo
{
    public partial class FrmLogQuery : Form
    {
        private SysAdminManager objAdminManager=new SysAdminManager();
        private DataPagerManager objPagerManager=new DataPagerManager();
        public FrmLogQuery()
        {
            InitializeComponent();
            //默认显示5条数据
            this.cbbPageSize.SelectedIndex = 0;
            //禁止自动生成列
            this.dgvLogs.AutoGenerateColumns = false;
            //禁止所有按钮
            this.btnFirst .Enabled = false;
            this.btnNext .Enabled = false;
            this.btnLast .Enabled = false;
            this.btnPrevious .Enabled = false;
            
        }
        private void FrmLogQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.objLogQuery = null;
        }
        //查询日志
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //查询第一页
            this.objPagerManager.CurrentPage = 1;
            Query();
            //如果是第一页，则禁用第一页和上一页的按钮
            this.btnFirst.Enabled = false;
            this.btnPrevious.Enabled = false;
        }
        //查询方法
        private void Query()
        {
            //开启所有按钮
            this.btnFirst.Enabled = true;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
            this.btnPrevious.Enabled = true;
            //设置参数并执行查询
            this.objPagerManager.PageSize = Convert.ToInt32(this.cbbPageSize.Text);//查询每页显示多少条
            DataTable dt = objPagerManager.QueryLog(this.dtpStart.Text, this.dtpEnd.Text);//根据时间进行查询

            //显示查询结果
            this.dgvLogs.DataSource = dt;
            new DataGridViewStyle().DgvStyle1(this.dgvLogs);

            //显示查询结果
            this.lblPageCount .Text =objPagerManager .PageCount .ToString();
            this.lblRecordCount .Text =objPagerManager  .RecordCount .ToString();
            if (this.lblPageCount.Text == "0")
            {
                this.lblCurrentPage.Text = "0";//总页数为0  则当前页数也为0
            }
            else
            {
                this.lblCurrentPage .Text =objPagerManager.CurrentPage . ToString();
            }
            if (this.lblPageCount.Text == "0" || this.lblPageCount.Text == "1")//总页数为0或者1时  禁止所有按钮
            {
                //禁用所有按钮
                this.btnFirst.Enabled = false;
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
                this.btnPrevious.Enabled = false;
                //this.btnGoTo.Enabled = false;
            }
            else
            {
                this.btnGoTo .Enabled = true;//总页数不为0或1时 跳转按钮可以启用
            }
            //如果没有查询到结果
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有找到符合条件的信息","提示信息");
            }
        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //上一页查询
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.objPagerManager.CurrentPage-=1;
            Query();
            if (objPagerManager.CurrentPage == 1)//当当前页是第一页的时候 禁用第一页和上一页的按钮
            {
                this.btnFirst.Enabled = false;
                this.btnPrevious.Enabled = false;
            }
        }
        //查询第一页
        private void btnFirst_Click(object sender, EventArgs e)
        {
            //查询第一页
            this.objPagerManager.CurrentPage = 1;
            Query();
            this.btnFirst.Enabled = false;
            this.btnPrevious.Enabled = false;
        }
        //查询下一页
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.objPagerManager.CurrentPage ++;
            Query();
            if (objPagerManager.CurrentPage == objPagerManager .PageCount )//当当前页是等于总页数时 禁用按钮
            {
                this.btnLast .Enabled = false;
                this.btnNext .Enabled = false;
            }
        }
        //最后一页
        private void btnLast_Click(object sender, EventArgs e)
        {
            this.objPagerManager.CurrentPage=objPagerManager .PageCount;
            Query();
            this.btnLast .Enabled = false;
            this.btnNext .Enabled = false;
        }

        //显示行号
        private void dgvLogs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvLogs ,e);
        }
        //跳转到指定页
        private void btnGoTo_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtGoTo.Text.Length == 0)
            {
                MessageBox.Show("请输入要跳转的页码", "信息提示");
                this.txtGoTo.Focus();
                return;
            }
            if (!DataValidate.IsPositiveInteger(this.txtGoTo.Text.Trim()))
            {
                MessageBox.Show("跳转的页码数必须是正整数", "信息提示");
                this.txtGoTo.Focus();
                this.txtGoTo.SelectAll();
                return;
            }
            //跳转到的页数不能大于总页数
            int pageIndex = Convert.ToInt32(this.txtGoTo.Text.Trim());
            if (pageIndex > objPagerManager.PageCount)
            {
                MessageBox.Show("跳转的页数不能大于总页数", "提示信息");
                this.txtGoTo.Focus();
                this.txtGoTo.SelectAll();
                return;
            }
            objPagerManager.CurrentPage = pageIndex;
            Query();//进行查询
            if (objPagerManager.CurrentPage == 1)
            {
                this.btnFirst.Enabled = false;
                this.btnPrevious.Enabled = false;
            }
            else if (objPagerManager.CurrentPage == objPagerManager.PageCount)
            {
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }

        }
        private void txtGoTo_KeyDown(object sender, KeyEventArgs e)
        {
            //btnGoTo_Click(null, null);
        }
    }
}
