using SMManagerDemo.AdminManager;
using SMManagerDemo.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SMManagerDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.lblAdminName.Text = "【管理员】：" + Program.currentAdmin.AdminName;//显示当前登录人员的姓名
            
        }
        //退出系统
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //退出系统
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //窗体关闭之前进行询问是否退出
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出系统吗？", "询问提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) 
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        //窗体关闭之后进行日志保存
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            new SysAdminManager().WriteExitTime(Program.currentAdmin.LoginLogId);
        }
        #region 让窗体在容器panle2的中间位置显示
        private void ForStartPosition(Form objForm)
        {
            objForm.Location  = new Point(
                this.Location .X +this.panel1.Width +(this.panel2 .Width-objForm .Width )/2+12,
                this.Location .Y +(this.panel2 .Height -objForm .Height) /2+50);
        }
        #endregion

        #region 创建各个子窗体
        //创建添加商品窗体
        public static FrmAddProduct objAddProduct = null;
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (objAddProduct == null)//没有窗体时
            {
                objAddProduct = new FrmAddProduct();//创建窗体
                objAddProduct.Show();
            }
            else//当窗体存在时激活窗体
            {
                objAddProduct.Activate();
                objAddProduct.WindowState = FormWindowState.Normal;
            }
            ForStartPosition(objAddProduct);
        }

        //商品入库窗体
        public static FrmProductStorage objStorage = null;
        private void btnProductInventor_Click(object sender, EventArgs e)
        {
            if (objStorage == null)
            {
                objStorage = new FrmProductStorage();
                objStorage.Show();
            }
            else
            {
                objStorage.Activate();
                objStorage.WindowState = FormWindowState.Normal;
            }
            ForStartPosition(objStorage);
        }

        //库存管理窗体
        public static FrmInventoryManage objInventory = null;

        private void btnInventoryManage_Click(object sender, EventArgs e)
        {
            if (objInventory == null)
            {
                objInventory = new FrmInventoryManage();
                objInventory.Show();
            }
            else
            {
                objInventory.Activate();
                objInventory.WindowState = FormWindowState.Normal;
            }
            ForStartPosition(objInventory);
        }

        //商品维护窗体
         public static  FrmProductManage objProduct = null;

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            if (objProduct == null)
            {
                objProduct = new FrmProductManage();
                objProduct.Show();
            }
            else
            {
                objProduct.Activate();
                objProduct.WindowState = FormWindowState.Normal;
            }
            ForStartPosition(objProduct);
        }

        //销售统计
        public static FrmSaleStat objSaleStat = null;

        private void btnSalAnalasys_Click(object sender, EventArgs e)
        {
            if (objSaleStat == null)
            {
                objSaleStat = new FrmSaleStat();
                objSaleStat.Show();
            }
            else
            {
                objSaleStat.Activate();
                objSaleStat.WindowState = FormWindowState.Normal;
            }
            ForStartPosition(objSaleStat);
        }

        //日志查询窗体
        public static FrmLogQuery objLogQuery = null;
        private void btnLogQuery_Click(object sender, EventArgs e)
        {
            if (objLogQuery == null)
            {
                objLogQuery = new FrmLogQuery();
                objLogQuery.Show();
            }
            else
            {
                objLogQuery.Activate();
                objLogQuery.WindowState = FormWindowState.Normal;
            }
            ForStartPosition(objLogQuery);
        }

        //修改密码窗体
        public static FrmModifyPwd objModifyPwd = null;
        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            if (objModifyPwd == null)
            {
                objModifyPwd = new FrmModifyPwd();
                objModifyPwd.Show();
            }
            else
            {
                objModifyPwd.Activate();
                objModifyPwd.WindowState = FormWindowState.Normal;
            }
            ForStartPosition(objModifyPwd);
        }

        //用户管理
        public static FrmAdminManage objAdminanage = null;
        private void tsmiUserManage_Click(object sender, EventArgs e)
        {

            if (objAdminanage == null)
            {
                objAdminanage = new FrmAdminManage();
                objAdminanage.Show();
            }
            else
            {
                objAdminanage.Activate();
                objAdminanage.WindowState = FormWindowState.Normal;
            }
            ForStartPosition(objAdminanage);
        }
        //修改密码
        private void tsmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objModifyPwd = new FrmModifyPwd();
            objModifyPwd.ShowDialog();
            ForStartPosition(objModifyPwd);
        }

        #endregion

        
    }
}
