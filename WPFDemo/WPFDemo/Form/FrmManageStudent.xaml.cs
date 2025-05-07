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
using DAL;
using Models;
using Models.Ext;

namespace WPFDemo
{
    /// <summary>
    /// FrmManageStudent.xaml 的交互逻辑
    /// </summary>
    public partial class FrmManageStudent : UserControl
    {
        private StudentClassService classService = new StudentClassService();
        private StudentService studentService = new StudentService();
        List<StudentExt> stuList = null;
        public FrmManageStudent()
        {
            InitializeComponent();
            this.cboClass .ItemsSource = classService.GetAllClasses();
            this.cboClass.DisplayMemberPath = "ClassName";
            this.cboClass.SelectedValuePath = "ClassId";
            this.cboClass.SelectedIndex = -1;

            
        }
        //按班级查询学员信息
        private void btnQueryList_Click(object sender, RoutedEventArgs e)
        {
            if (this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("请首先选择一个班级！", "查询提示");
                return; 
            }
            stuList = studentService.GetStudentByClass(this.cboClass.Text);
            this.dgvStudentList.ItemsSource = stuList;
        }

        private void btnNameASC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNameDesc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {

        }
        //关闭窗体
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
