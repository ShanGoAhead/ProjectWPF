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
using Models;

namespace SMManagerDemo.AdminManager
{
    public partial class FrmAdminManage : Form
    {
        private SysAdminManager  objAdminManager=new SysAdminManager();
        public FrmAdminManage()
        {
            InitializeComponent();
            //显示用户列表
            this.dgvAdminList.DataSource = objAdminManager.GetAdmins();
            this.dgvAdminList.AutoGenerateColumns = false;

        }
        //添加用户信息
        public static FrmAddAdmin   objFrmAddAdmin = null;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (objFrmAddAdmin == null)
            {
                objFrmAddAdmin = new FrmAddAdmin();
                objFrmAddAdmin.Show();
            }
            else
            {
                objFrmAddAdmin.Activate();
                objFrmAddAdmin.WindowState = FormWindowState.Normal;
            }
        }

        //修改用户信息
        public static FrmEditAdmin objFrmEditAdmin = null;
        private void btnModify_Click(object sender, EventArgs e)
        {
            //
            if (this.dgvAdminList.RowCount == 0)
            {
                MessageBox.Show("没有任何要修改的商品信息", "提示信息");
                return;
            }
            if (this.dgvAdminList.CurrentRow == null)
            {
                MessageBox.Show("没有选中要修改的行", "提示信息");
                return;
            }
            //获取用户的编号
            string LoginId = this.dgvAdminList.CurrentRow.Cells["LoginId"].Value.ToString();
            SysAdmin objSysAdmin=objAdminManager.GetByLoginId(LoginId);
            //创建要修改用户信息的窗体
            objFrmEditAdmin=new FrmEditAdmin(objSysAdmin);
            DialogResult result=objFrmEditAdmin.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.dgvAdminList.DataSource = objAdminManager.GetAdmins();
            }
        }
        //禁用 就是讲选中用户的状态值变为0
        private void btnDisable_Click(object sender, EventArgs e)
        {
            string statusName = this.dgvAdminList.CurrentRow.Cells["StatusName"].Value.ToString();
            if (statusName == "启用")
            {
                objAdminManager.UpdateDisStatus(this.dgvAdminList.CurrentRow.Cells["LoginId"].Value.ToString());
                this.dgvAdminList.DataSource = objAdminManager.GetAdmins();
            }
            else
            {
                MessageBox.Show("当前用户状态已经是禁用状态", "提示信息");
            }
        }
        //启用
        private void btnEnable_Click(object sender, EventArgs e)
        {
            string statusName = this.dgvAdminList.CurrentRow.Cells["StatusName"].Value.ToString();
            if (statusName == "禁用")
            {
                objAdminManager.UpdateEnStatus(this.dgvAdminList.CurrentRow.Cells["LoginId"].Value.ToString());
                this.dgvAdminList.DataSource = objAdminManager.GetAdmins();
            }
            else
            {
                MessageBox.Show("当前用户状态已经是启用状态", "提示信息");
            }
        }
        //当窗体关闭之前让窗体对象为空
        private void FrmAdminManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.objAdminanage = null;
        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
