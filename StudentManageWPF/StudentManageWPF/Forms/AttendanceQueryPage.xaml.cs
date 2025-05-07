using DAL;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentManageWPF.Forms
{
    /// <summary>
    /// AttendanceQueryPage.xaml 的交互逻辑
    /// </summary>
    public partial class AttendanceQueryPage : UserControl
    {
        private AttendanceService objAttendanceService = new AttendanceService();
        public AttendanceQueryPage()
        {
            InitializeComponent();
            dtpTime.SelectedDate = DateTime.Now;
        }
        #region 根据日期和姓名查询考勤
        private void btnQuery_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(this.dtpTime.Text);
            DateTime dt2 = dt1.AddDays(1.0);
            this.dgvStudentList.AutoGenerateColumns = false;
            this.dgvStudentList.ItemsSource = objAttendanceService.GetStuByDate(dt1,dt2,this.txtName .Text .Trim ());

            //显示应到、实到、缺勤人数
            this.lblCount.Content = objAttendanceService.GetAllStudents();
            this.lblReal.Content = objAttendanceService.GetAttendStudents(dt1,true);
            this.lblAbsenceCount.Content = (Convert.ToInt32(this.lblCount.Content) - Convert.ToInt32(this.lblReal.Content)).ToString();

        }
        #endregion

        #region 关闭窗体
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
        #endregion 
    }
}
