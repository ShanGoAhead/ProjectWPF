using Models;
using Models.Ext;
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
    /// StudentInfoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StudentInfoWindow : Window
    {
        public StudentInfoWindow()
        {
            InitializeComponent();
        }
        public StudentInfoWindow(StudentExt objStudent):this()
        {
            this.lblStudentName .Content = objStudent.StudentName;
            this.lblGender.Content = objStudent.Gender;
            this.lblBirthday.Content = objStudent.Birthday.ToShortDateString();
            this.lblClassName.Content = objStudent.ClassName;
            this.lblStudentIdNo.Content = objStudent.StudentIdNo;
            this.lblCardNo.Content = objStudent.CardNo;
            this.lblPhoneNumber.Content = objStudent.PhoneNumber;
            this.lblStudentAdress.Content = objStudent.StudentAdress;
        }
        #region 关闭窗体
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
        #endregion 
    }
}
