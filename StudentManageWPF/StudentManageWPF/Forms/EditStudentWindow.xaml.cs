
using Common;
using DAL;
using Microsoft.Win32;
using Models;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentManageWPF.Forms
{
    /// <summary>
    /// EditStudentWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EditStudentWindow : Window
    {
        private StudentService objStuService = new StudentService();
        private StudentClassService objClassService = new StudentClassService();
        OpenFileDialog objFileDialog = new OpenFileDialog();
        private string currentStuImageBase64;
        public EditStudentWindow(StudentExt objStudent)
        {
            InitializeComponent();
            this.cboClassName.ItemsSource = objClassService.GetAllClasses();
            this.cboClassName.DisplayMemberPath = "ClassName";
            this.cboClassName.SelectedValuePath = "ClassId";
            this.txtStudentId.Text = objStudent.StudentId.ToString();
            this.txtStudentName.Text = objStudent.StudentName;
            if (objStudent.Gender == "男") this.rdoMale.IsChecked = true;
            else this.rdoFemale.IsChecked = true;
            this.txtCardNo.Text = objStudent.CardNo;
            this.txtPhoneNumber.Text = objStudent.PhoneNumber;
            this.txtAddress.Text = objStudent.StudentAdress;
            this.cboClassName.Text = objStudent.ClassName;
            this.dtpBirthday.Text = objStudent.Birthday.ToShortDateString();
            this.txtStudentIdNo.Text = objStudent.StudentIdNo;
            if (!string.IsNullOrEmpty(objStudent.StuImage))
            {
                try
                {
                    byte[] imageBytes = Convert.FromBase64String(objStudent.StuImage);
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

        #region 提交修改
        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            #region【1】数据验证
            //验证姓名
            if (this.txtStudentName.Text.Length == 0)
            {
                MessageBox.Show("请输入学员姓名！", "提示信息");
                this.txtStudentName.Focus();
                return;
            }
            //验证考勤卡号
            if (this.txtCardNo.Text.Length == 0)
            {
                MessageBox.Show("请输入学员考勤卡号！", "提示信息");
                this.txtCardNo.Focus();
                return;
            }
            //验证性别
            if (this.rdoFemale.IsChecked == false && this.rdoMale.IsChecked == false)
            {
                MessageBox.Show("请选择学生性别！", "提示信息");
                return;
            }
            //验证身份是否为空
            if (this.txtStudentIdNo.Text.Length == 0)
            {
                MessageBox.Show("请输入学员身份证号！", "提示信息");
                this.txtStudentIdNo.Focus();
                return;
            }
            //验证身份证号是否符合要求
            if (!Common.DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号不符合要求！", "验证提示");
                this.txtStudentIdNo.Focus();
                return;
            }
            //验证身份证号是否和出生日期相吻合
            string month = string.Empty;
            string day = string.Empty;
            if (Convert.ToDateTime(this.dtpBirthday.Text).Month < 10)
                month = "0" + Convert.ToDateTime(this.dtpBirthday.Text).Month;
            if (Convert.ToDateTime(this.dtpBirthday.Text).Day < 10)
                day = "0" + Convert.ToDateTime(this.dtpBirthday.Text).Day;
            string birthday = Convert.ToDateTime(this.dtpBirthday.Text).Year.ToString() + month + day;

            if (!this.txtStudentIdNo.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证号和出生日期不匹配！", "验证提示");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }
            //验证出生日期
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age < 18)
            {
                MessageBox.Show("学生年龄不能小于18岁！", "验证提示");
                return;
            }

            #endregion

            #region 【2】封装对象
            Student objStudent = new Student()
            {
                StudentId = Convert.ToInt32(this.txtStudentId.Text),
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoFemale.IsChecked == true ? "女" : "男",
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                StudentIdNo = this.txtStudentIdNo.Text,
                CardNo = this.txtCardNo.Text,
                PhoneNumber = this.txtPhoneNumber.Text,
                StudentAdress = this.txtAddress.Text,
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                StuImage = !string.IsNullOrEmpty(currentStuImageBase64) ?
               currentStuImageBase64 :
               (this.imgStu.Source != null ? objFileDialog.FileName : "")
            };
            #endregion

            #region 【3】调用方法
            try
            {
                if (objStuService.ModifyStudent(objStudent) == 1)
                {
                    MessageBox.Show("修改学员信息成功！", "提示信息");
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

        #region 选择照片
        private void btnChoseImage_Click(object sender, RoutedEventArgs e)
        {
            objFileDialog.Filter = "图片文件|*.jpg;*.png;*.bmp"; // 添加文件过滤器
            if (objFileDialog.ShowDialog() == true)
            {
                try
                {
                    // 显示新图片
                    imgStu.Source = new BitmapImage(new Uri(objFileDialog.FileName));

                    // 将新图片转为Base64存储
                    byte[] imageBytes = File.ReadAllBytes(objFileDialog.FileName);
                    currentStuImageBase64 = Convert.ToBase64String(imageBytes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"图片加载失败: {ex.Message}");
                    currentStuImageBase64 = string.Empty;
                }
            }
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
