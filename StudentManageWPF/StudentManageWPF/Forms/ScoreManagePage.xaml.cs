using DAL;
using Models;
using Models.Ext;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// ScoreManagePage.xaml 的交互逻辑
    /// </summary>
    public partial class ScoreManagePage : UserControl
    {
        private StudentClassService objClassService = new StudentClassService();
        private ScoreListService objScoreService = new ScoreListService();
        private DataSet ds = null;//保存全部查询结果的数据集
        public ScoreManagePage()
        {
            InitializeComponent();
            //断开事件
            this.cboClass.SelectionChanged -= cboClass_SelectionChanged;
            this.cboClass.ItemsSource = objClassService.GetAllClasses();
            this.cboClass.DisplayMemberPath = "ClassName";
            this.cboClass.SelectedValuePath = "ClassId";
            this.cboClass.SelectedIndex = -1;
            //显示全部成绩
            ds = objScoreService.GetAllScoreList();
            this.dgvStudentList.ItemsSource = ds.Tables[0].DefaultView;
            //禁止列排序，保证列标题居中
            foreach (DataGridColumn item in this.dgvStudentList.Columns)
            {
                item.CanUserSort = false;
            }
            //挂接事件
            this.cboClass.SelectionChanged += cboClass_SelectionChanged;
        }
        private void cboClass_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (this.cboClass.SelectedIndex== -1)
            {
                MessageBox.Show("请首先选择要查询的班级", "查询提示");
                return;
            }
            var a = this.cboClass.SelectedItem as StudentClass;
            this.dgvStudentList.AutoGenerateColumns = false;
            this.ds.Tables[0].DefaultView.RowFilter = "ClassName='" + a.ClassName + "'";

            //同步显示成绩统计信息
            this.gbStat.Header = "[" + a.ClassName + "]考试成绩统计";
            Dictionary<string, string> dic = objScoreService.GetScoreInfoByClassId(this.cboClass .SelectedValue.ToString ());
            this.lblCount.Content = dic["absentCount"];
            this.lblAttendCount.Content = dic["stuCount"];
            this.lblCSharpAvg.Content = dic["avgCSharp"];
            this.lblDBAvg.Content = dic["avgDB"];

            //显示缺考人员名单
            List<string> stulist = objScoreService.GetAbsentListByClassId(this.cboClass.SelectedValue.ToString());
            this.lblList.Items.Clear();
            if (stulist.Count == 0)
            {
                this.lblList.Items.Add("没有缺考");
            }
            else
            {
                for (int x = 0; x < stulist.Count; x++)
                {
                    lblList.Items.Add(stulist[x]);
                }
            }
        }
        #region 显示全校考试成绩信息
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            this.gbStat.Header = "全校考试成绩统计";
            this.dgvStudentList.AutoGenerateColumns = false;
            ds = objScoreService.GetAllScoreList();
            this.dgvStudentList.ItemsSource = ds.Tables[0].DefaultView;

            //同步显示成绩信息
            Dictionary<string, string> dic = objScoreService.GetScoreInfo();
            this.lblCount.Content = dic["absectCount"];
            this.lblAttendCount.Content = dic["stuCount"];
            this.lblCSharpAvg.Content = dic["avgCSharp"];
            this.lblDBAvg.Content = dic["avgDB"];
            //显示缺考人员名单
            List<string> stulist = objScoreService.GetAbsentList();
            this.lblList.Items.Clear();
            if (stulist.Count == 0)
            {
                this.lblList.Items.Add("没有缺考");
            }
            else
            {
                for (int x = 0; x < stulist.Count; x++)
                {
                    lblList.Items.Add(stulist[x]);
                }
            }
        }
        #endregion 
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
