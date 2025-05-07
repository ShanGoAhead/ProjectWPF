using DAL;
using Models.Ext;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// AttendancePage.xaml 的交互逻辑
    /// </summary>
    public partial class AttendancePage : UserControl
    {
        private AttendanceService objAttendanceService = new AttendanceService();
        private StudentService objStuService = new StudentService();
        private List<StudentExt> stuList = new List<StudentExt>();
        public AttendancePage()
        {
            InitializeComponent();
            //获取考勤的学员总数
            this.lblCount.Content = objAttendanceService.GetAllStudents();
            timer1_Tick(null, null);
            ShowStat();
        }
        #region 初始化信息
        //显示出勤人数
        private void ShowStat()
        {
            //显示实际的出勤人数
            this.lblReal.Content = objAttendanceService.GetAttendStudents(DateTime.Now, true);
            //显示缺勤人数
            this.lblAbsenceCount.Content = (Convert.ToInt32(this.lblCount.Content) - Convert.ToInt32(this.lblReal.Content)).ToString();
        }
        //显示当前时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblYear.Content = DateTime.Now.Year;
            this.lblMonth.Content = DateTime.Now.Month;
            this.lblDay.Content = DateTime.Now.Day;
            this.lblTime.Content = DateTime.Now.ToLongTimeString();
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    this.lblWeek.Content = "一";
                    break;
                case DayOfWeek.Tuesday:
                    this.lblWeek.Content = "二";
                    break;
                case DayOfWeek.Wednesday:
                    this.lblWeek.Content = "三";
                    break;
                case DayOfWeek.Thursday:
                    this.lblWeek.Content = "四";
                    break;
                case DayOfWeek.Friday:
                    this.lblWeek.Content = "五";
                    break;
                case DayOfWeek.Saturday:
                    this.lblWeek.Content = "六";
                    break;
                case DayOfWeek.Sunday:
                    this.lblWeek.Content = "日";
                    break;

            }
            ;
        }
        #endregion 

        #region 当窗体加载完成时 卡号获取焦点
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.txtStuCardNo.Focus();
        }
        #endregion 

        #region 输入卡号回车进行打卡
        private void txtStuCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            //【1】数据验证
            if (this.txtStuCardNo.Text.Length == 0)
            {
                MessageBox.Show("请输入考勤卡号！", "提示信息");
                this.txtStuCardNo.Focus();
                return;
            }
            if (!objStuService.IsCardNoExisted(this.txtStuCardNo.Text))
            {
                MessageBox.Show("输入的卡号不存在！", "提示信息");
                this.txtStuCardNo.SelectAll();
                this.txtStuCardNo.Focus();
                return;
            }
            StudentExt objStu = new StudentService().GetStudentByCardNo(this.txtStuCardNo.Text.Trim());
            stuList.Add(new StudentExt
            {
                DTime = DateTime.Now ,
                StudentId = objStu.StudentId,
                CardNo = objStu.CardNo,
                StudentName = objStu.StudentName,
                Gender=objStu .Gender ,
                ClassName =objStu .ClassName 
            });

            this.dgvStudentList.ItemsSource = null;
            this.dgvStudentList.ItemsSource = stuList;
            this.lblStuname.Content = objStu.StudentName;
            this.lblStuId.Content = objStu.StudentId;
            this.lblStuClass.Content = objStu.ClassName;
            if (!string.IsNullOrEmpty(objStu.StuImage))
            {
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(objStu.StuImage);
                    imgStu.Source = ByteArrayToImage(imageBytes);
                }
                catch (FormatException)
                {
                    // 防止数据不是有效 base64 时崩溃
                    imgStu.Source = new BitmapImage(new Uri("default.png", UriKind.Relative));
                }
            }
            else
            {
                imgStu.Source = new BitmapImage(new Uri("default.png", UriKind.Relative));
            }

            //进行打卡
            string result = objAttendanceService.AddRecord(this.txtStuCardNo.Text.Trim());
            if (result != "success")
            {
                this.lblInfo.Content = "打卡失败！";
                MessageBox.Show(result, "错误提示");
            }
            else
            {
                this.lblInfo.Content = "打卡成功！";
                ShowStat();
                this.txtStuCardNo.Text = ""; //等待下一个打卡
                this.txtStuCardNo.Focus();
            }
        }

        #region 如果你频繁从 byte[] 加载图片，可以创建一个帮助方法
        public static BitmapImage ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = ms;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.EndInit();
                image.Freeze(); // 可选：线程安全
                return image;
            }
        }
        #endregion
        #endregion

        #region 结束打卡
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
        #endregion 
    }
}
