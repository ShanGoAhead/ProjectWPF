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
    public partial class FrmModifyPwd : Form
    { 
        private SysAdminManager  objAdminManager=new SysAdminManager();
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            #region 数据验证
            if (this.txtOldPwd.Text.Length == 0)
            {
                MessageBox.Show("请输入原密码","提示信息");
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtOldPwd.Text.Trim() != Program.currentAdmin.LoginPwd.ToString ())
            {
                MessageBox.Show("输入的原密码不正确，请重新输入！", "修改提示");
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtNewPwd .Text.Length == 0)
            {
                MessageBox.Show("请输入新密码", "提示信息");
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Trim().Length < 8)
            {
                MessageBox.Show("输入的密码长度不能小于8位", "修改提示");
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtConfirmPwd.Text.Length == 0)
            {
                MessageBox.Show("请输入确认密码", "提示信息");
                this.txtConfirmPwd.Focus();
                return;
            }
            //新密码和确认密码必须一样
            if (this.txtNewPwd.Text.Trim() != this.txtConfirmPwd.Text.Trim())
            {
                MessageBox.Show("确认密码和新密码不一致","提示信息");
                this.txtConfirmPwd .Clear();
                this.txtConfirmPwd.Focus();
                return;
            }
            #endregion

            #region 封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Program.currentAdmin.LoginId,
                LoginPwd = this.txtNewPwd.Text.Trim()
            };
            #endregion

            #region 调用方法进行修改密码
            try
            {
                if (objAdminManager.ModifyPwd(objAdmin) == 1)
                {
                    MessageBox.Show("密码修改成功", "修改提示");
                    //修改成功以后保存新的密码
                    Program.currentAdmin.LoginPwd = this.txtConfirmPwd.Text.Trim();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
