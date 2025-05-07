using Common;
using DAL;
using Microsoft.Win32;
using Models;
using Models.Ext;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// ScoreQueryPage.xaml 的交互逻辑
    /// </summary>
    public partial class ScoreQueryPage : UserControl
    {
        private ScoreListService objScoreService = new ScoreListService();
        private DataSet ds = null;//保存全部查询结果的数据集

        public ScoreQueryPage()
        {
            InitializeComponent();
            this.cboClass.ItemsSource = new StudentClassService().GetAllClasses();
            this.cboClass.DisplayMemberPath = "ClassName";
            this.cboClass.SelectedValuePath = "ClassId";
            //显示全部成绩
            ds = objScoreService.GetAllScoreList();
            this.dgvScoreList.ItemsSource = ds.Tables[0].DefaultView;
            //禁止列排序，保证列标题居中
            foreach (DataGridColumn item in this.dgvScoreList.Columns)
            {
                item.CanUserSort = false;
            }
        }
        #region 显示全部成绩
        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            this.ds.Tables[0].DefaultView.RowFilter = "ClassName like '%%'";
        }
        #endregion

        #region 打印当前成绩
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var selectRow = this.dgvScoreList.SelectedItem as DataRowView;
            if (selectRow == null)
            {
                MessageBox.Show("没有任何需要打印的学员信息！", "提示信息");
                return;
            }
            StudentExt a = new StudentExt()
            {
                StudentId = Convert.ToInt32(selectRow["StudentId"]),
                StudentName = selectRow["StudentName"].ToString(),
                Gender=selectRow["Gender"].ToString (),
                ClassName =selectRow["ClassName"].ToString (),
                PhoneNumber =selectRow["PhoneNumber"].ToString (),
                CSharp =selectRow["CSharp"].ToString (),
                SQLServer=selectRow["SQLServer"].ToString ()
            };
            //创建打印内容
            FlowDocument doc = new FlowDocument();
            Paragraph title = new Paragraph(new Run("学员成绩"));
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
            AddRow("手机号码", a.PhoneNumber);
            AddRow("C#成绩", a.CSharp);
            AddRow("数据库成绩", a.SQLServer);

            doc.Blocks.Add(table);

            System.Windows.Controls.PrintDialog pd = new System.Windows.Controls.PrintDialog();
            if (pd.ShowDialog() == true)
            {
                IDocumentPaginatorSource dps = doc;
                pd.PrintDocument(dps.DocumentPaginator, "打印单个学员信息");
            }
        }
        #endregion

        #region 关闭窗体
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
        #endregion

        #region 根据班级名称动态筛选
        private void cboClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级！", "提示信息");
                return;
            }
            var a = this.cboClass.SelectedItem as StudentClass;
            this.ds.Tables[0].DefaultView.RowFilter = "ClassName='" + a.ClassName + "'";
        }
        #endregion

        #region 根据C#成绩动态筛选 
        private void txtScore_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.txtScore.Text.Length == 0) return;
            if (!DataValidate.IsInteger(this.txtScore.Text)) return;
            else
            {
                ds.Tables[0].DefaultView.RowFilter = "CSharp>" + this.txtScore.Text.Trim();
            }
        }
        #endregion
    }
}
