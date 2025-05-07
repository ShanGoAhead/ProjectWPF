using Common;
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

namespace StudentManageWPF.Forms
{
    /// <summary>
    /// ModifyPwdWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ModifyPwdWindow : Window
    {
        public ModifyPwdWindow()
        {
            InitializeComponent();
        }
        #region 确认修改
        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            #region 【1】数据验证
            if (this.txtOldPwd.Text.Length == 0)
            {
                MessageBox.Show("请输入原密码！", "提示信息");
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtOldPwd.Text != FrmMain.objCurrentAdmin.LoginPwd)
            {
                MessageBox.Show("原密码错误！", "错误信息");
                this.txtOldPwd.SelectAll();
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Length == 0)
            {
                MessageBox.Show("请输入新密码！", "提示信息");
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Length < 6)
            {
                MessageBox.Show("密码不能小于6位数！", "提示信息");
                this.txtNewPwd.SelectAll();
                this.txtNewPwd.Focus();
                return;
            }
            if (!DataValidate.IsInteger(this.txtNewPwd.Text))
            {
                MessageBox.Show("密码必须为正整数！", "提示信息");
                this.txtNewPwd.SelectAll();
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtNewPwdConfirm.Text.Length == 0)
            {
                MessageBox.Show("请输入确认密码！", "提示信息");
                this.txtNewPwdConfirm.Focus();
                return;
            }
            if (this.txtNewPwdConfirm.Text.Trim() != this.txtNewPwd.Text.Trim()) 
            {
                MessageBox.Show("确认密码与新密码不一致！", "提示信息");
                this.txtNewPwdConfirm.SelectAll();
                this.txtNewPwdConfirm.Focus();
                return;
            }
            #endregion

            #region 【2】封装对象
            Admin objAdmin = new Admin() {
                LoginId =FrmMain .objCurrentAdmin .LoginId ,
                LoginPwd =this.txtNewPwd .Text .Trim ()
            };
            #endregion

            #region 【3】调用方法
            try
            {
                int result = new AdminService().ModifyPwd(objAdmin);
                if (result == 1)
                {
                    MessageBox.Show("密码修改成功，请妥善保管！", "成功提示");
                    //同时修改当前保存的用户密码
                    FrmMain.objCurrentAdmin.LoginPwd = this.txtNewPwd.Text.Trim();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            #endregion 
        }
        #endregion

        #region 取消修改
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
        #endregion 
    }
}
