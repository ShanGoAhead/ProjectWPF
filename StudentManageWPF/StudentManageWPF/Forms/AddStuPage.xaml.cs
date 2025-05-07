using Common;
using DAL;
using Microsoft.Win32;
using Models;
using OpenCvSharp;
using OpenCvSharp.WpfExtensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;



namespace StudentManageWPF.Forms
{
    /// <summary>
    /// AddStuPage.xaml 的交互逻辑
    /// </summary>
    public partial class AddStuPage : System.Windows.Controls.UserControl
    {
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        private List<Student> stuList = new List<Student>();
        OpenFileDialog objFileDialog = new OpenFileDialog();
        public AddStuPage()
        {
            InitializeComponent();
            this.cboClassName.ItemsSource = objClassService.GetAllClasses();
            this.cboClassName.DisplayMemberPath = "ClassName";
            this.cboClassName.SelectedValuePath = "ClassId";
            this.cboClassName.SelectedIndex = -1;
        }

        private void userAddStu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)//按下ESC键关闭窗体
            {
                this.Visibility = Visibility.Hidden;
            }
        }

        //启动摄像头
        private void btnStartVideo_Click(object sender, RoutedEventArgs e)
        {
        }
        //关闭摄像头
        private void btnCloseVideo_Click(object sender, RoutedEventArgs e)
        {
        }
        //开始拍照
        private void btnTake_Click(object sender, RoutedEventArgs e)
        {
            
        }
        //清除照片
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            this.imgPic.Source = null;
        }
        //选择照片
        private void btnChoseImage_Click(object sender, RoutedEventArgs e)
        {
            Nullable<bool> result = objFileDialog.ShowDialog();
            if (result == true)
                imgPic.Source = new BitmapImage(new Uri(objFileDialog.FileName, UriKind.RelativeOrAbsolute));
        }
        //关闭窗体
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        //确认添加学员
        private void btnAddConfirm_Click(object sender, RoutedEventArgs e)
        {
            #region 【1】数据验证 
            if (this.txtStudentName.Text.Length == 0)
            {
                MessageBox.Show("请输入学员姓名！", "提示信息");
                this.txtStudentName.Focus();
                return;
            }
            if (this.txtStudentIdNo.Text.Length == 0)
            {
                MessageBox.Show("请输入学员身份证号！", "提示信息");
                this.txtStudentIdNo.Focus();
                return;
            }
            if (this.txtCardNo.Text.Length == 0)
            {
                MessageBox.Show("请输入学员卡号！", "提示信息");
                this.txtCardNo.Focus();
                return;
            }
            if (this.rdoFemale.IsChecked == false && this.rdoMale.IsChecked == false)
            {
                MessageBox.Show("请选择学生性别！", "提示信息");
                return;
            }
            if (objStudentService.IsCardNoExisted(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号不能和现有学员身份证号重复！", "验证提示");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号不符合要求！", "验证提示");
                this.txtStudentIdNo.Focus();
                return;
            }
            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学员所在班级！", "提示信息");
                return;
            }
            //验证年龄是否在18-35岁之间
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age > 35 || age < 18)
            {
                MessageBox.Show("年龄必须在18-35岁之间！", "提示信息");
                return;
            }
            //验证身份证号是否和出生日期匹配  
            if (!this.txtStudentIdNo.Text.Contains(Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd")))
            {
                MessageBox.Show("身份证号和出生日期不匹配！", "验证提示");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }
            //验证卡号是否重复
            if (objStudentService.IsCardNoExisted(this.txtCardNo.Text.Trim()))
            {
                MessageBox.Show("当前卡号已经存在！", "验证提示");
                this.txtCardNo.Focus();
                this.txtCardNo.SelectAll();
                return;
            }
            #endregion

            #region 【2】封装对象
            string base64Image = "";
            if (this.imgPic.Source != null && objFileDialog.FileName != null)
            {
                byte[] imageBytes = File.ReadAllBytes(objFileDialog.FileName);
                base64Image = Convert.ToBase64String(imageBytes);
            }
            Student objStudent = new Student()
            {
                StudentName = this.txtStudentName.Text.Trim(),
                StudentIdNo = this.txtStudentIdNo.Text.Trim(),
                StudentAdress = this.txtAddress.Text.Trim() == "" ? "地址不详" : this.txtAddress.Text.Trim(),
                CardNo = this.txtCardNo.Text.Trim(),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                ClassName = this.cboClassName.Text,
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                Age = Convert.ToInt32(DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year),
                Gender = this.rdoFemale.IsChecked == true ? "女" : "男",
                StuImage = base64Image
            };
            #endregion

            #region 【3】调用方法添加学员
            try
            {
                int StudentId = objStudentService.AddStudent(objStudent);
                if (StudentId > 1)
                {
                    //同步显示学员信息
                    objStudent.StudentId = StudentId;
                    this.stuList.Add(objStudent);
                    this.dgvStudentList.ItemsSource = null;
                    this.dgvStudentList.ItemsSource = this.stuList;
                    //询问是否继续添加
                    MessageBoxResult result = MessageBox.Show("新学员添加成功!是否继续添加？", "提示信息",
                               MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        //清除信息
                        foreach (var ctrls in Grid_Info.Children)
                        {
                            if (ctrls is TextBox textBox)
                            {
                                textBox.Text = "";
                            }
                        }
                        this.cboClassName.SelectedIndex = -1;
                        this.rdoFemale.IsChecked = false;
                        this.rdoMale.IsChecked = false;
                        this.txtStudentName.Focus();
                        this.imgPic.Source = null;
                    }
                    else this.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion 
        }
    }
}
