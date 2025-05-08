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
    public partial class FrmProductManage : Form
    {
        private ProductManager objProManager=new ProductManager();
        public FrmProductManage()
        {
            InitializeComponent();
            //初始化商品分类下拉框
            List<ProductCategory> categoryList = objProManager.GetAllCategory();
            categoryList.Insert (0,new ProductCategory() { CategoryId =-1,CategoryName =""});
            this.cboCategory.DataSource = categoryList;
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.ValueMember = "CategoryId";
            this.cboCategory.SelectedIndex = -1;

            //禁止自动生成列
            this.dgvProduct.AutoGenerateColumns = false; 

        }

        private void FrmProductManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.objProduct = null;
        }
        //进行查询
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
            this.dgvProduct .DataSource = objProManager.QueryInventoryInfo(this.txtProductId.Text.Trim(), 
               this.txtProductName.Text.Trim(), categoryId);
        }
      
        //根据商品编号更新商品折扣
        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            objProManager.UpdateDiscount(this.dgvProduct .CurrentRow .Cells["ProductId"].Value .ToString (),
                this.txtDiscount .Text .Trim ());
            btnQuery_Click(null, null);
        }
        //商品入库
        public static FrmProductStorage frmStore = null;
        private void btnStorage_Click(object sender, EventArgs e)
        {
            if (frmStore == null)
            {
                frmStore = new FrmProductStorage();
                frmStore.Show();
            }
            else
            {
                frmStore.Activate();
                frmStore.WindowState = FormWindowState.Normal;
            }
        }
        //添加新商品 创建添加商品窗体
        public static FrmAddProduct frmAddProduct = null; 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmAddProduct == null)
            {
                frmAddProduct = new FrmAddProduct();
                frmAddProduct.Show();
            }
            else
            {
                frmAddProduct.Activate();
                frmAddProduct.WindowState = FormWindowState.Normal;
            }
        }
        //删除商品
        private void btnDel_Click(object sender, EventArgs e)
        {
            //没有显示行的数据时
            if (this.dgvProduct.RowCount == 0)
            {
                MessageBox.Show("没有任何要修改的商品信息", "提示信息");
                return;
            }
            //没有选中商品信息
            if (this.dgvProduct.CurrentRow == null)
            {
                MessageBox.Show("没有选中要修改的学员信息", "提示信息");
                return;
            }
            //获取要删除商品的名称
            string productName = objProManager .GetProductById(this.dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString()).ProductName;
            //询问是否删除该商品
            DialogResult result = MessageBox.Show("请问要删除[" + productName + "]学员吗", "删除询问", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);
            //如果顾客点击取消 返回
            if (result == DialogResult.Cancel)
            {
                return;
            }
            //获取商品的编号
            string productId = this.dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString();
            try
            {
                if (objProManager.DeleteProduct(productId) == 1)
                {
                    //同步刷新商品信息列表
                    btnQuery_Click(null, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "提示信息");
            }
        }
        //修改商品 创建修改商品的窗体
        public static FrmEditProduct objFrmEdit = null;
        private void btnModify_Click(object sender, EventArgs e)
        {
            //没有显示行的数据时
            if (this.dgvProduct.RowCount == 0)
            {
                MessageBox.Show("没有任何要修改的商品信息","提示信息");
                return;
            }
            //没有选中商品信息
            if (this.dgvProduct.CurrentRow == null)
            {
                MessageBox.Show("没有选中要修改的商品信息", "提示信息");
                return;
            }
            //获取要修改的商品编号
            string ProductId = this.dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString();
            Products objProcudt=objProManager.GetProductById(ProductId);
            //创建修改商品信息的窗体
            objFrmEdit=new FrmEditProduct(objProcudt );
            DialogResult result = objFrmEdit.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnQuery_Click(null, null);
            }
        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
