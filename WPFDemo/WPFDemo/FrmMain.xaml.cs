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
    /// FrmMain.xaml 的交互逻辑
    /// </summary>
    public partial class FrmMain : Window
    {
        public FrmMain()
        {
            InitializeComponent();
            #region 登陆窗体验证

            FrmAdminLogin  loginForm = new FrmAdminLogin();

            loginForm.ShowDialog();

            if (loginForm.DialogResult != Convert.ToBoolean(1))
            {
                //终止进程
                Environment.Exit(0);
            }
            #endregion
        }
        //窗体关闭之前
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        //无边框窗体拖动
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
        //退出
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //添加学员
        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {

        }
        //学员管理
        private void btnStudentManage_Click(object sender, RoutedEventArgs e)
        {
            gridContent.Children.Clear();
            FrmManageStudent manageStudent = new FrmManageStudent();
            gridContent.Children.Add(manageStudent);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        //考勤管理
        private void btnBalance_Click(object sender, RoutedEventArgs e)
        {

        }
        //修改密码
        private void btnModifyPwd_Click(object sender, RoutedEventArgs e)
        {

        }
        //退出系统
        private void btnExitSys_Click(object sender, RoutedEventArgs e)
        {

        }
        //成绩管理
        private void btnScoreManage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
