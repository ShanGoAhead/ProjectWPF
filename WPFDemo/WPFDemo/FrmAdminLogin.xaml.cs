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

namespace WPFDemo
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
            this.txtLoginId.Focus();
        }
        #region 无边框窗体拖动
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            // 获取鼠标相对标题栏位置 
            Point position = e.GetPosition(this);
            // 如果鼠标位置在标题栏内，允许拖动 
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (position.X >= 0 && position.X < this.ActualWidth && position.Y >= 0 && position.Y < this.ActualHeight)
                {
                    this.DragMove();
                }
            }
        }
        #endregion
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //【1】数据验证
            if (this.txtLoginId.Text.Length == 0)
            {
                MessageBox.Show("请输入账号！");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txtLoginPwd.Password.Length == 0)
            {
                MessageBox.Show("请输入密码！");
                this.txtLoginPwd.Focus();
                return;
            }
            //【2】封装对象
            Admin objAdmin = new Admin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Password
            };
            //【3】调用方法
            objAdmin = objAdminService.AdminLogin(objAdmin);
            try
            {
                if (objAdmin != null)
                {
                    //保存当前对象
                    App.currentAdmin = objAdmin;
                    //设置窗体返回值
                    this.DialogResult =true;
                    //关闭窗体
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户或密码错误");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据访问出现异常，登录失败！具体原因：" + ex.Message);
            }
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        //改善用户体验
        private void txtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtLoginId.Text.Length != 0 &&this.txtLoginPwd .Password !=null && e.Key == Key.Enter)
            {
                btnLogin_Click(null,null);
            }
        }

        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtLoginId.Text.Length != 0 && e.Key == Key.Enter)
            {
                if (this.txtLoginId.Text.Length != 0)
                {
                    this.txtLoginPwd.Focus();//将当前焦点跳转到密码框
                }
            }
        }
    }
}
