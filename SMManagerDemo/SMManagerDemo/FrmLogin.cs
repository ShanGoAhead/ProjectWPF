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
    public partial class FrmLogin : Form
    {
        private SysAdminManager objAdminManager=new SysAdminManager();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //【1】数据验证
            if (this.txtLoginId.Text.Trim().Length  == 0)
            {
                MessageBox.Show("请输入登录账号！","登录提示");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length  == 0)
            {
                MessageBox.Show("请输入登录密码！", "登录提示");
                this.txtLoginPwd.Focus();
                return;
            }
            //判断密码是否是正整数
            if (!DataValidate.IsPositiveInteger(this.txtLoginPwd.Text.Trim()))
            {
                MessageBox.Show("密码必须是正数", "提示信息");
                return;
            }
            //[2]封装对象
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32 ( this.txtLoginId.Text.Trim()),
                LoginPwd =this.txtLoginPwd .Text .Trim()
            };
            try
            {
                //【3】调用逻辑方法查询并执行相关任务
                objAdmin =objAdminManager .AdminLogin(objAdmin);
                if (objAdmin != null)//说明账号密码正确，再进行判断账号状态
                {
                    //判断账号的状态
                    if (objAdmin.AdminStatus != 1)
                    {
                        MessageBox.Show("当前管理员账号被禁用", "登录提示");
                    }
                    else
                    {
                        //保存当前账号的用户
                        Program.currentAdmin = objAdmin;
                        //窗体的返回值
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("用户名或者密码错误！", "登录提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("用户登录时发生错误！具体信息是："+ex.Message);
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
