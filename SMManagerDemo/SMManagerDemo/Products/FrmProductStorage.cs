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
using BLL;

namespace SMManagerDemo.Product
{
    public partial class FrmProductStorage : Form
    {
        private ProductManager objProManager=new ProductManager();
        public FrmProductStorage()
        {
            InitializeComponent();
        }

        private void FrmProductStorage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.objStorage = null;
        }
        //检验商品编号是否对应产品
        private bool ValidateProductId()
        {
            //没有输入商品编号
            if (this.txtProductId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入商品的编号！","提示信息");
                this.txtProductId.Focus();
                return false;
            }
            //输入编号号进行查询
            Products objProduct=objProManager .GetProductById(this.txtProductId.Text);
            if (objProduct == null)//不存在该商品 
            {
                MessageBox.Show("商品编号不存在，请重新添加商品信息或者修改当前商品编号！", "提示信息");
                this.txtProductId.Clear();
                this.txtProductName.Clear();
                this.txtProductId.Focus();
                return false;
            }
            else//商品编号存在 显示商品名称  商品数量获取焦点
            {
                this.txtProductName.Text = objProduct.ProductName;
                this.txtQuantity.Focus();
                return true;
            }
        }
        //查询商品信息
        private void txtProductId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ValidateProductId();
            }
        }
        //商品编号对话框鼠标离开事件与鼠标KeyDown事件是一样的
        private void txtProductId_Leave(object sender, EventArgs e)
        {
            ValidateProductId();
        }
        //执行商品入库（点击“入库确认”按钮）
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //数据验证（库存必须是整数）
            if (!DataValidate.IsInteger(this.txtQuantity.Text.Trim()))
            {
                MessageBox.Show("库存必须是整数","提示信息");
                this.txtQuantity.Clear();
                this.txtQuantity.Focus();
            }
            //进行更新库存
            objProManager.Updatelnventory(this.txtProductId.Text.Trim(), this.txtQuantity.Text.Trim());
            this.txtProductId.Clear();
            this.txtProductName.Clear();
            this.txtQuantity.Clear();
            this.txtProductId .Focus();

        }
     
        //执行商品入库（在“入库数量”文本框中点击回车键）
        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtQuantity.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                btnConfirm_Click(null, null);
            }
        }

      
    }
}
