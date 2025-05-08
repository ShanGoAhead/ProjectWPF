using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

using System.Net;
using System.Data;

namespace BLL
{

    public class SysAdminManager
    {
        //创建数据访问对象
        private SysAdminService objAdminService = new SysAdminService();
        
        /// <summary>
        /// 根据登录账号和密码查询管理员信息
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            //[1]根据用户账号和密码调用后台查询
            objAdmin = objAdminService.AdminLogin(objAdmin);
            //判断用户信息是否正确，同时用户状态是否为“启用”也就是值是否为1
            if (objAdmin != null && objAdmin.AdminStatus == 1)
            {
                //写入登录日志 并保存当前用户的日志Id
                LoginLogs log = new LoginLogs()
                {
                    LoginId = objAdmin.LoginId,
                    SPName = objAdmin.AdminName,
                    ServerName = Dns.GetHostName()//获取本地计算机名称
                };
                //保存当前管理员登录日志的ID(为后面退出系统，写入退出时间旧志做准备)
                objAdmin.LoginLogId = objAdminService.WriteLoginLogs(log);
            }
            return objAdmin;
        }

        /// <summary>
        /// 将用户退出的时间保存在日志中
        /// </summary>
        /// <param name="logId"></param>
        /// <returns></returns>
        public int WriteExitTime(int logId)
        {
            return objAdminService.WriteExitTime(logId);
        }
        //修改密码
        public int ModifyPwd(SysAdmin objAdmin)
        {
            return objAdminService.ModifyPwd(objAdmin);
        }

        //获取所有管理者信息
        public DataTable GetAdmins()
        {
            return objAdminService.GetAdmins();
        }
        /// <summary>
        /// 增加管理员
        /// </summary>
        /// <returns></returns>
        public int AddAdmin(SysAdmin objAdmin)
        {
            return objAdminService.AddAdmin(objAdmin);
        }
        //启用
        public int UpdateEnStatus(string loginId)
        {
            return objAdminService.UpdateEnStatus(loginId);
        }
        //禁用
        public int UpdateDisStatus(string loginId)
        {
            return objAdminService.UpdateDisStatus(loginId);
        }
        //修改管理员信息
        public int EditAdmin(SysAdmin objSysAdmin)
        {
            return objAdminService.EditAdmin(objSysAdmin);
        }
        //根据账号获取用户信息
        public SysAdmin GetByLoginId(string loginId)
        {
           return  objAdminService.GetByLoginId(loginId);
        }


       
        //获取所有用户状态
        public List<UserStatus> GetAllStatus()
        {
            return objAdminService.GetAllStatus();
        }
      
        //获取所有用户角色
        public List<Role> GetAllRole()
        {
            return objAdminService.GetAllRole();
        }
    }
}
