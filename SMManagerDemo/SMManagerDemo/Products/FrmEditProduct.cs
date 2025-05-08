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
using Models;

namespace SMManagerDemo.Product
{
    public partial class FrmEditProduct : Form
    {
        private ProductManager  objProManager=new ProductManager();
        public FrmEditProduct()
        {
            InitializeComponent();
        }
        public FrmEditProduct(Products objProduct):this()
        {
            //初始化商品分类和单位的下拉框
            this.cboCategory.DataSource = objProManager.GetAllCategory();
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.ValueMember = "CategoryId";
            

            this.cboUnit.Items.AddRange(objProManager.GetAllUnit());
            this.cboUnit.SelectedIndex = -1;

            //显示窗体信息
            this.txtProductId .Text = objProduct.ProductId;
            this.txtProductName .Text = objProduct.ProductName;
            this.txtUnitPrice.Text = objProduct.UnitPrice.ToString ();
            this.cboCategory.Text = objProduct.CategoryName;
            this.cboUnit.Text = objProduct.Unit;
        }

        private void FrmEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmProductManage.objFrmEdit = null;
        }
        
        //修改商品
        private void btnSubmit_Click(object sender, EventArgs e)
        {
             //【1】数据验证
            if (this.txtProductName.Text.Length == 0)
            {
                MessageBox.Show("请输入商品名称", "提示信息 ");
                this.txtProductName.Focus();
                return;
            }
            if (this.txtUnitPrice.Text.Length == 0)
            {
                MessageBox.Show("请输入商品单价", "提示信息 ");
                this.txtUnitPrice.Focus();
                return;
            }
            if (this.cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("请选择商品分类", "提示信息 ");
                this.cboCategory.Focus();
                return;
            }
            if (this.cboUnit .SelectedIndex == -1)
            {
                MessageBox.Show("请选择商品计量单位", "提示信息 ");
                this.cboUnit.Focus();
                return;
            }
            //封装对象
            Products objProduct = new Products()
            {
                ProductId = this.txtProductId.Text.Trim(),
                ProductName = this.txtProductName .Text.Trim(),
                UnitPrice  =Convert.ToDecimal (this.txtUnitPrice .Text.Trim()),
                Unit = this.cboUnit .Text .Trim(),
                CategoryId  = Convert.ToInt32 (this.cboUnit.SelectedValue)
            };
            try
            {
                if (objProManager.EditProduct(objProduct)==1)
                {
                    MessageBox.Show("商品信息修改成功", "提示信息");
                    //返回修改成功的信息
                    this.DialogResult = DialogResult.OK;
                    // 关闭窗口
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息是"+ex.Message);
            }
        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
