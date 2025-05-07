using Common;
using DAL;
using Microsoft.Win32;
using Models;
using Models.Ext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace StudentManageWPF.Forms
{
    /// <summary>
    /// StuManagePage.xaml 的交互逻辑
    /// </summary>
    public partial class StuManagePage : UserControl
    {
        private StudentClassService objClassServcie = new StudentClassService();
        private StudentService objStuService = new StudentService();
        private List<StudentExt> stuList = null;

        public StuManagePage()
        {
            InitializeComponent();
            this.cboClass.ItemsSource = objClassServcie.GetAllClasses();
            this.cboClass.DisplayMemberPath = "ClassName";
            this.cboClass.SelectedValuePath = "ClassId";
            this.cboClass.SelectedIndex = -1;

        }
        #region 提交查询
        private void btnQuery_Click(object sender, RoutedEventArgs e)
        {
            if (this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("请选则班级！", "提示");
                return;
            }
            this.dgvStudentList.AutoGenerateColumns = false;    //不显示未封装的属性
            stuList = objStuService.GetStudentByClass(this.cboClass.Text);
            this.dgvStudentList.ItemsSource = null;
            this.dgvStudentList.ItemsSource = stuList;
        }
        #endregion

        #region 姓名降序
        private void btnNameDESC_Click(object sender, RoutedEventArgs e)
        {
            if (this.dgvStudentList == null)
            {
                return;
            }
            stuList.Sort(new NameDesc());
            this.dgvStudentList.ItemsSource = null;
            this.dgvStudentList.ItemsSource = stuList;
        }
        #endregion

        #region 学号降序
        private void btnStuIdDESC_Click(object sender, RoutedEventArgs e)
        {
            if (this.dgvStudentList == null)
            {
                return;
            }
            stuList.Sort(new StuIdDESC());
            this.dgvStudentList.ItemsSource = null;
            this.dgvStudentList.ItemsSource = stuList;
        }

        #endregion

        #region 修改学员信息
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var a = this.dgvStudentList.SelectedItem as StudentExt;
            if (a == null)
            {
                MessageBox.Show("没有任何需要修改的学员信息！", "提示");
                return;
            }
            //获取学号
            string StudentId = a.StudentId.ToString();
            StudentExt objStudent = objStuService.GetStudentById(StudentId);
            EditStudentWindow editStuWindow = new EditStudentWindow(objStudent);
            editStuWindow.ShowDialog();
            btnQuery_Click(null, null);

        }
        #endregion

        #region 删除学员
        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var a = this.dgvStudentList.SelectedItem as StudentExt;
            if (a == null)
            {
                MessageBox.Show("没有任何需要修改的学员信息！", "提示信息");
                return;
            }
            //删除确认
            MessageBoxResult result = MessageBox.Show("确实要删除吗？", "删除确认", MessageBoxButton.OKCancel,
                 MessageBoxImage.Question);
            if (result == MessageBoxResult.Cancel) return;
            //获取学号
            string StudentId = a.StudentId.ToString();
            try
            {
                if (objStuService.DeleteStudentById(StudentId) == 1)
                {
                    MessageBox.Show("删除成功！", "提示信息");
                    btnQuery_Click(null, null);  //同步刷新显示
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示信息");
            }
        }
        #endregion

        #region 导出到Excel
        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            if (dgvStudentList.ItemsSource == null)
            {
                MessageBox.Show("没有数据可导出。");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV文件 (*.csv)|*.csv",
                FileName = "导出的学员信息.csv"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                var sb = new StringBuilder();

                // 取列头
                foreach (DataGridColumn column in dgvStudentList.Columns)
                {
                    sb.Append(column.Header + ",");
                }
                sb.AppendLine();

                // 取每行数据
                foreach (var item in dgvStudentList.Items)
                {
                    if (item is StudentExt student)
                    {
                        // 身份证号加单引号防止 Excel 科学计数法
                        sb.Append($"{student.StudentId},{student.StudentName},{student.Gender},'{student.StudentIdNo},{student.Birthday.ToShortDateString()},{student.PhoneNumber},{student.ClassName}");
                        sb.AppendLine();
                    }
                }

                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("导出成功！");
            }
        }
        #endregion

        #region 打印当前学员信息
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var a = this.dgvStudentList.SelectedItem as StudentExt;
            if (a == null)
            {
                MessageBox.Show("没有任何需要打印的学员信息！", "提示信息");
                return;
            }
            // 创建打印内容
            FlowDocument doc = new FlowDocument();
            Paragraph title = new Paragraph(new Run("学员信息"));
            title.FontSize = 20;
            title.FontWeight = FontWeights.Bold;
            title.TextAlignment = TextAlignment.Center;
            doc.Blocks.Add(title);

            Table table = new Table();
            table.Columns.Add(new TableColumn());
            table.Columns.Add(new TableColumn());

            TableRowGroup trg = new TableRowGroup();
            table.RowGroups.Add(trg);

            void AddRow(string label, string value)
            {
                TableRow row = new TableRow();
                row.Cells.Add(new TableCell(new Paragraph(new Run(label))));
                row.Cells.Add(new TableCell(new Paragraph(new Run(value))));
                trg.Rows.Add(row);
            }

            AddRow("姓名", a.StudentName);
            AddRow("学号", a.StudentId.ToString());
            AddRow("性别", a.Gender);
            AddRow("班级", a.ClassName);
            AddRow("出生日期", a.Birthday.ToShortDateString());
            AddRow("身份证号", a.StudentIdNo);
            AddRow("手机号码", a.PhoneNumber);
            AddRow("卡号", a.CardNo);
            AddRow("家庭住址", a.StudentAdress);

            doc.Blocks.Add(table);

            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                IDocumentPaginatorSource dps = doc;
                pd.PrintDocument(dps.DocumentPaginator, "打印单个学员信息");
            }
        }

        #endregion

        #region 根据学号查询
        private void btnQueryById_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtStudentId.Text.Length == 0)
            {
                MessageBox.Show("请输入学号！", "提示信息");
                this.txtStudentId.Focus();
                return;
            }
            if (!DataValidate.IsInteger(this.txtStudentId.Text))
            {
                MessageBox.Show("学号必须是正整数！", "提示信息");
                this.txtStudentId.SelectAll();
                this.txtStudentId.Focus();
                return;
            }
            StudentExt objStudent = objStuService.GetStudentById(this.txtStudentId.Text);
            if (objStudent == null)
            {
                MessageBox.Show("学号不存在！", "提示信息");
                this.txtStudentId.Focus();
            }
            else
            {
                StudentInfoWindow objStudentInfo = new StudentInfoWindow(objStudent);
                objStudentInfo.Show();

            }
        }
        #endregion

        #region 关闭窗体
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
        #endregion

        #region 实现排序方法
        //按姓名降序
        class NameDesc : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return y.StudentName.CompareTo(x.StudentName);
            }
        }
        //按学号降序
        class StuIdDESC : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return y.StudentId.CompareTo(x.StudentId);
            }
        }
        #endregion

        #region 双击选中的学员对象并显示详细信息

        private void dgvStudentList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var a = this.dgvStudentList.SelectedItem as StudentExt;
            txtStudentId.Text = a.StudentId.ToString();
            StudentExt objStudent = objStuService.GetStudentById(this.txtStudentId.Text.Trim());
            StudentInfoWindow objStuInfo = new StudentInfoWindow(objStudent);
            objStuInfo.Show();
        }
        #endregion 
    }
}
