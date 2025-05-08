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
    public partial class FrmAddProduct : Form
    {
        private ProductManager objProManager = new ProductManager();
        public FrmAddProduct()
        {
            InitializeComponent();
            //获取商品分类列表
            this.cboCategory.DataSource = objProManager.GetAllCategory();
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.ValueMember = "CategoryId";
            this.cboCategory.SelectedIndex = -1;

            //获取商品的单位
            //this.cboUnit .DataSource = objProManager.GetAllUnit();
            //this.cboUnit .Text = objProManager.GetAllUnit().ToString();
            this.cboUnit.Items.AddRange(objProManager.GetAllUnit());
            this.cboUnit.SelectedIndex = -1;
        }
        //锁定
        private void btnLock_Click(object sender, EventArgs e)
        {
            if (this.btnLock.Text == "锁定")
            {
                this.cboCategory.Enabled = false;
                this.cboUnit.Enabled = false;
                this.btnLock.Text = "解锁";
            }
            else
            {
                this.cboCategory.Enabled = true;
                this.cboUnit.Enabled = true;
                this.btnLock.Text = "锁定";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.objAddProduct = null;
        }
        //添加商品信息
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region【1】数据验证

            if (this.cboCategory.Text.Length == 0)
            {
                MessageBox.Show("请选择商品分类", "提示信息");
                return;
            }
            if (this.cboUnit.Text.Length == 0)
            {
                MessageBox.Show("请选择商品计量单位", "提示信息");
                return;
            }
            if (this.txtProductId .Text.Length == 0)
            {
                MessageBox.Show("商品编码不能为空", "提示信息");
                return;
            }
            if (this.txtProductName .Text.Length == 0)
            {
                MessageBox.Show("商品名称不能为空", "提示信息");
                return;
            }
            if (this.txtUnitPrice .Text.Length == 0)
            {
                MessageBox.Show("商品单价不能为空", "提示信息");
                return;
            }
            if (this.txtMaxCount .Text.Length == 0)
            {
                MessageBox.Show("商品最大库存不能为空", "提示信息");
                return;
            }
            if (this.txtMinCount.Text.Length == 0)
            {
                MessageBox.Show("商品最小库存不能为空", "提示信息");
                return;
            }
            #endregion

            #region【2】封装商品对象
            Products objProduct = new Products()
            {
                //CategoryName = this.cboCategory.Text.Trim(),
                CategoryId =Convert.ToInt32 (this.cboCategory .SelectedValue),
                Unit = this.cboUnit.Text.Trim(),
                ProductId =this.txtProductId .Text.Trim(),
                ProductName = this.txtProductName .Text.Trim(),
                UnitPrice =Convert.ToDecimal (this.txtUnitPrice .Text .Trim ()),
                MaxCount =Convert.ToInt32 ( this.txtMaxCount .Text .Trim ()),
                MinCount = Convert.ToInt32(this.txtMinCount .Text .Trim ())
            };
            #endregion

            //【3】调用添加 商品方法 进行添加商品
            try
            {
                objProManager.AddProduct(objProduct);
                DialogResult result = MessageBox.Show("添加商品成功，是否继续添加？", "询问提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)//继续添加
                {
                    this.txtMaxCount.Text = "";
                    this.txtMinCount.Clear();
                    foreach (Control item in this.gbInfo.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                        else if (item is ComboBox)
                        {
                            if (this.btnLock.Text == "锁定")
                            {
                                ((ComboBox)item).SelectedIndex = -1;
                            }
                        }
                    }
                    this.txtProductId.Focus();
                }
                else//取消继续添加  关闭窗体
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息为：" + ex.Message, "错误信息");
            }
            
        }
        
    }
}
