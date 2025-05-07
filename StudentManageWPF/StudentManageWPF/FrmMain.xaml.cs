using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using StudentManageWPF.Forms;
using Models;


namespace StudentManageWPF
{
    /// <summary>
    /// FrmMain.xaml 的交互逻辑
    /// </summary>
    public partial class FrmMain : Window
    {
        public static Admin objCurrentAdmin = null;
        public FrmMain()
        {
            InitializeComponent();
            #region 登录窗体验证
            FrmAdminLogin loginWindow = new FrmAdminLogin();
            loginWindow.ShowDialog();
            if (loginWindow.DialogResult == false)
            {
                Environment.Exit(0);
            }
            #endregion 
        }
        #region 快捷键
        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            try
            {
                if (e.Key == Key.F2)
                {
                    this.Close();
                }
                else if (e.Key == Key.Escape)
                {
                    this.WindowState = WindowState.Normal;
                    this.WindowStyle = WindowStyle.SingleBorderWindow;
                    this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                }
                else if (e.Key == Key.F4)
                {
                    this.WindowState = WindowState.Maximized;
                    this.WindowStyle = WindowStyle.None;
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region 添加学员窗体
        private void btnAddStu_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            AddStuPage addStudent = new AddStuPage();
            Grid_Content.Children.Add(addStudent);
        }
        private void menuAddStu_Click(object sender, RoutedEventArgs e)
        {
            btnAddStu_Click(null,null);
        }
        #endregion

        #region 学员管理窗体
        private void btnStuManage_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            StuManagePage stuManage = new StuManagePage();
            Grid_Content.Children.Add(stuManage);
        }
        private void menuManagerStu_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion 

        #region 考勤打卡
        private void btnCard_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            AttendancePage attendancePage = new AttendancePage();
            Grid_Content.Children.Add(attendancePage);
        }
        private void menuCard_Click(object sender, RoutedEventArgs e)
        {
            btnCard_Click(null,null);
        }
        #endregion

        #region 考勤查询
        private void btnAttendanceQuery_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            AttendanceQueryPage attendanceQueryPage = new AttendanceQueryPage();
            Grid_Content.Children.Add(attendanceQueryPage);

        }
        private void menuAQuery_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region 成绩查询
        private void btnScoreQuery_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            ScoreManagePage scoreManagePage = new ScoreManagePage();
            Grid_Content.Children.Add(scoreManagePage);
        }
        private void menuQuery_Click(object sender, RoutedEventArgs e)
        {
            btnScoreQuery_Click(null,null);
        }
        #endregion 

        #region 成绩分析
        private void btnScoreAnalasys_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            ScoreQueryPage scoreQueryPage = new ScoreQueryPage();
            Grid_Content.Children.Add(scoreQueryPage);
        }
        private void menuQueryAndAnalysis_Click(object sender, RoutedEventArgs e)
        {
            btnScoreAnalasys_Click(null,null);
        }
        #endregion

        #region 修改密码
        private void btnModifyPwd_Click(object sender, RoutedEventArgs e)
        {
            ModifyPwdWindow modifyPwdWindow = new ModifyPwdWindow();
            modifyPwdWindow.Show();
        }
        private void tmiModifyPwd_Click(object sender, RoutedEventArgs e)
        {
            btnModifyPwd_Click(null,null);
        }
        #endregion

        #region 账号切换
        private void btnChangeAccount_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            FrmAdminLogin  objUserLogin = new FrmAdminLogin();
            objUserLogin.Title = "[账号切换]";
            System.Windows.Forms.DialogResult result;
            if (objUserLogin.ShowDialog() == true)
            {
                result = System.Windows.Forms.DialogResult.OK;
                //根据窗体返回值判断用户登录是否成功
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.lblCurrentUser.Text = FrmMain.objCurrentAdmin.AdminName + "]";
                }
            }
            ;
        }
        #endregion 

        #region 系统升级
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("目前已经是最高版本！","提示信息");
        }
        private void menuUpdate_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("目前已经是最高版本！", "提示信息");
        }
        #endregion 

        #region 批量导入
        private void btnImportStu_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            ImportDataPage importData = new ImportDataPage();
            Grid_Content.Children.Add(importData);
        }
        private void menuImport_Click(object sender, RoutedEventArgs e)
        {
            Grid_Content.Children.Clear();
            ImportDataPage importData = new ImportDataPage();
            Grid_Content.Children.Add(importData);
        }
        #endregion

        #region 访问官网
        private void btnGoXiketang_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.taobao.com");
        }
        private void menuLinkxkt_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region 退出系统
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void menuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //退出系统前询问
        private void LayoutWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("确定要关闭窗口吗？", "提示", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true; // 取消关闭操作
            }
        }
        #endregion


    }
}
