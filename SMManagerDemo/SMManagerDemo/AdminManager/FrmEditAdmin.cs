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

namespace SMManagerDemo.AdminManager
{
    public partial class FrmEditAdmin : Form
    {
        private SysAdminManager objAdminManager = new SysAdminManager();
        
        public FrmEditAdmin()
        {
            InitializeComponent();  
        }
        public FrmEditAdmin(SysAdmin objSysAdmin):this()
        {
            //初始化下拉框
            this.cboRole.DataSource = objAdminManager.GetAllRole();
            this.cboRole.DisplayMember = "RoleName";
            this.cboRole.ValueMember = "RoleId";

            this.cboStatus.DataSource = objAdminManager.GetAllStatus();
            this.cboStatus.DisplayMember = "StatusName";
            this.cboStatus.ValueMember = "AdminStatus";

            //显示窗体信息
            this.txtLoginId .Text =objSysAdmin .LoginId .ToString();
            this.txtAdminName.Text = objSysAdmin.AdminName;

            this.cboRole.SelectedIndex = objSysAdmin.RoleId-1;//因为角色的值1代表超级管理员  2代表一般管理员 需要对状态值进行-1 才能与索引相匹配
            this.cboStatus.SelectedIndex = objSysAdmin.AdminStatus;//0表示禁用 1表示启用

            
        }
      
        private void FrmEditAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.objModifyPwd = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtAdminName .Text.Length == 0)
            {
                MessageBox.Show("用户姓名不能为空","提示信息");
                return;
            }
            if (this.cboRole .Text.Length == 0)
            {
                MessageBox.Show("请选择用户类型", "提示信息");
                return;
            }
            if (this.cboStatus .Text.Length == 0)
            {
                MessageBox.Show("请选择用户状态", "提示信息");
                return;
            }

            //封装对象
            SysAdmin objSysAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId .Text),
                AdminName = this.txtAdminName.Text,
                RoleId = Convert.ToInt32(this.cboRole.SelectedValue),
                AdminStatus  = Convert.ToInt32(this.cboStatus .SelectedValue)
            };

            //调用方法修改信息
            try
            {
                if (objAdminManager.EditAdmin(objSysAdmin) == 1)
                {
                    MessageBox.Show("修改成功", "提示信息");
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
            //关闭
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
