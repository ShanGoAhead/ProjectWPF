using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //程序启动的时候执行的事件
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            FrmMain mainForm = new FrmMain();
            FrmAdminLogin loginForm = new FrmAdminLogin();
           
            if (loginForm.DialogResult == true)
            {
                mainForm.Show();
            }
            else
            {
                mainForm.Close();
            }
        }
        //保存登录对象
        public  static Admin  currentAdmin = null;
    }
}
