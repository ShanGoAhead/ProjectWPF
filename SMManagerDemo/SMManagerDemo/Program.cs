using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMManagerDemo
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //禁止启动多个项目进程
            Process[] processArray = Process.GetProcesses();//获取所有进程
            int currentCount = 0;//当前进程的总数
            foreach (Process item in processArray)
            {
                if (item.ProcessName == Process.GetCurrentProcess().ProcessName)
                {
                    currentCount += 1;             
                       
                }
            }
            if (currentCount > 1)//当进程数量大于1个时，禁止再次运行其他进程
            {
                Application.Exit();
                return;
            }

            //显示登录窗体
            FrmLogin fm = new FrmLogin();
            DialogResult result= fm.ShowDialog();

            //判断是否登陆成功
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }
        }
        public static SysAdmin currentAdmin = null;
    }
}
