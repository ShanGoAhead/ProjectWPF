using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMManagerDemo.Product
{
    public partial class FrmInventoryManage : Form
    {
        private ProductManager objProManager = new ProductManager();
        public FrmInventoryManage()
        {
            InitializeComponent();
            //初始化商品分类下拉框
            List<ProductCategory> categoryList = objProManager.GetAllCategory();
            //给下拉框添加一个空值
            categoryList.Insert(0, new ProductCategory() { CategoryId = -1, CategoryName = "" });
            this.cboCategory.DataSource = categoryList;
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.ValueMember = "CategoryId";
            this.cboCategory.SelectedIndex = -1;

            //禁止自动生成列
            this.dgvProduct.AutoGenerateColumns = false;

        }
        //显示库存预警商品信息的方法
        private void ShowInventory()
        {
            //定义输出参数
            int totalCount = 0;
            int maxCount = 0;
            int minCount = 0;
            //调用后台带参数的存储过程，并显示产品列表
            this.dgvProduct.DataSource = objProManager.QueryWarningInfo(out totalCount ,out maxCount ,out minCount);
            //显示输出参数
            this.lblCount.Text = totalCount.ToString();
            this.lblMaxCount .Text = maxCount.ToString();
            this.lblMinCount .Text = minCount.ToString();
        }
        //清空文本框数据（当点击提交查询、显示超库存、显示低库存、显示库存预警这几个按钮时 清空下面三个文本框）
        private void ClearText()
        {
            this.txtMaxCount.Text = "";
            this.txtMinCount.Text = "";
            this.txtTotalCount.Text = "";
        }
      
        private void FrmInventoryManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.objInventory = null;
        }
        //提交查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //数据验证
            //当三个条件都没有选择的时候 进行提示
            if (this.txtProductId.Text.Trim().Length == 0 && this.txtProductName.Text.Trim().Length == 0
                && this.cboCategory.Text.Length == 0)
            {
                MessageBox.Show("请选择至少一个查询条件", "查询提示");
            }
            string categoryId = "";
            if (this.cboCategory.SelectedIndex != -1)
            {
                categoryId = this.cboCategory.SelectedValue.ToString();
            }
            this.dgvProduct.DataSource = objProManager.QueryInventoryInfo(this.txtProductId.Text.Trim(),
            this.txtProductName.Text.Trim(), categoryId);

        }
        private void txtMaxCount_TextChanged(object sender, EventArgs e)
        {
        }
        //选中某一行同步显示该商品的库存数据
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProduct.CurrentRow == null || this.dgvProduct.RowCount == 0) return;
            this.txtMaxCount .Text =this.dgvProduct .CurrentRow.Cells["MaxCount"].Value .ToString();
            this.txtMinCount .Text =this.dgvProduct .CurrentRow .Cells["MinCount"].Value.ToString();
            this.txtTotalCount.Text = this.dgvProduct.CurrentRow.Cells["TotalCount"].Value.ToString();

        }
        //更新商品当前库存
        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            objProManager.UpdateTotalCount(this.txtTotalCount .Text .Trim (),this.dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString());
            btnQuery_Click(null, null);
        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //刷新库存预警信息
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowInventory();
            DateTime.Compare(DateTime.Now , DateTime.Now);
            ClearText();
        }
        //显示超库存信息
        private void btnShowMax_Click(object sender, EventArgs e)
        {
            this.dgvProduct.DataSource = objProManager.QueryInventoryMax();
            ClearText();
        }
        //显示低库存
        private void btnShowMin_Click(object sender, EventArgs e)
        {
            this.dgvProduct.DataSource = objProManager.QueryInventoryMin();
            ClearText();
        }
        //显示行号
        private void dgvProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvProduct , e);
        }
        //更新商品最大库存和最小库存
        private void btnUpdateSet_Click(object sender, EventArgs e)
        {
            objProManager.UpdateInventory(this.dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString(), this.txtMaxCount.Text.Trim(),
                this.txtMinCount.Text.Trim());
            this.dgvProduct.CurrentRow.Cells["MaxCount"].Value = this.txtMaxCount.Text;
            this.dgvProduct.CurrentRow.Cells["MinCount"].Value = this.txtMinCount.Text;
            btnQuery_Click(null, null);
        }
    }
}
