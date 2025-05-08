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

namespace SMManagerDemo
{
    public partial class FrmAddAdmin : Form
    {
        private SysAdminManager objAdminManager = new SysAdminManager();
        public List<SysAdmin> listAdmin = null;
        public FrmAddAdmin()
        {
            InitializeComponent();
            //初始化下拉框
            
            this.cboRole.DataSource = objAdminManager.GetAllRole();
            this.cboRole.DisplayMember = "RoleName";
            this.cboRole.ValueMember = "RoleId";
            this.cboRole.SelectedIndex = -1;

            this.cboStatus.DataSource = objAdminManager.GetAllStatus();
            this.cboStatus.DisplayMember = "StatusName";
            this.cboStatus.ValueMember = "AdminStatus";
            this.cboStatus.SelectedIndex = -1;

            
        }
        //添加用户
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region 数据验证
            //if (this.txtLoginId.Text.Length == 0)
            //{
            //    MessageBox.Show("请输入登录账户", "提示信息");
            //    this.txtLoginId.Focus();
            //    return;
            //}
            if (this.txtAdminName.Text.Length == 0)
            {
                MessageBox.Show("请输入用户名称", "提示信息");
                this.txtAdminName.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Length == 0)
            {
                MessageBox.Show("请输入用户密码", "提示信息");
                this.txtLoginPwd.Focus();
                return;
            }
            if (this.cboRole.Text.Length == 0)
            {
                MessageBox.Show("请选择用户类型", "提示信息");
                this.cboRole.Focus();
                return;
            }
            if (this.cboStatus.Text.Length == 0)
            {
                MessageBox.Show("请选择用户状态", "提示信息");
                this.cboStatus.Focus();
                return;
            }
            #endregion

            #region 封装对象
            SysAdmin objSysAdmin = new SysAdmin()
            {
                //LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim(),
                AdminName = this.txtAdminName.Text.Trim(),
                RoleId = Convert.ToInt32(this.cboRole.SelectedValue.ToString()),
                AdminStatus = Convert.ToInt32(this.cboStatus.SelectedValue.ToString())
            };
            #endregion

            #region 调用方法添加用户
            try
            {
                if (objAdminManager.AddAdmin(objSysAdmin) == 1)
                {
                    DialogResult result = MessageBox.Show("是否继续添加新用户", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        // this.txtLoginId.Clear();
                        this.txtAdminName.Clear();
                        this.cboRole.SelectedIndex = -1;
                    }
                    else
                    {
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("错误信息为：" + ex.Message);
            }
            #endregion 
        }
        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
