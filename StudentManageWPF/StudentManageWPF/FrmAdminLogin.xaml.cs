using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace StudentManageWPF
{
    /// <summary>
    /// FrmAdminLogin.xaml 的交互逻辑
    /// </summary>
    public partial class FrmAdminLogin : Window
    {
        private AdminService objAdminService = new AdminService();
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtLoginId.Text.Length !=0&&e.Key==Key .Enter )
            {
                if (this.txtLoginId.Text.Length != 0)
                {
                    this.txtLoginPwd.Focus();//将当前焦点跳转到密码框
                }
            }
        }

        private void txtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {

            if (this.txtLoginId.Text.Length != 0 && this.txtLoginPwd.Password != null && e.Key == Key.Enter)
            {
                btnLogin_Click(null, null);

            }
        }

        //退出登录
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //登录
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            #region 【1】数据验证
            if (this.txtLoginId.Text.Length == 0)
            {
                MessageBox.Show("请输入登录账号！");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txtLoginPwd.Password.Length == 0)
            {
                MessageBox.Show("请输入登录密码！");
                this.txtLoginPwd.Focus();
                return;
            }
            #endregion

            #region 【2】封装对象
            Admin objAdmin = new Admin() { 
            LoginId=Convert .ToInt32 (this.txtLoginId .Text ),
            LoginPwd=this.txtLoginPwd .Password
            };
            #endregion

            #region 【3】数据验证
            try
            {
                objAdmin = objAdminService.AdminLogin(objAdmin);
                if (objAdmin != null)
                {
                    FrmMain.objCurrentAdmin = objAdmin;
                    this.DialogResult = Convert.ToBoolean(1);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("账号或密码不正确！","提示信息");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("数据访问出现异常，登录失败！具体原因：" + ex.Message);
            }
            #endregion

        }

    }
}
