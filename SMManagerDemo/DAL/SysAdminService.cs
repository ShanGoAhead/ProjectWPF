using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class SysAdminService
    {
        /// <summary>
        /// 根据登绿账号和密码查询管理员信息
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            //【1】封装参数
            SqlParameter[] param = new SqlParameter[]
            {

                new SqlParameter("@LoginId",objAdmin.LoginId ),
                new SqlParameter("@LoginPwd",objAdmin.LoginPwd )
            };
            //【2】调用带参数的存储过程
            SqlDataReader objReader = SQLHelper.GetReaderByProcedure("usp_AdminLogin", param);
            //【3】读取结果
            if (objReader.Read())
            {
                objAdmin.AdminName = objReader["AdminName"].ToString();
                objAdmin.AdminStatus = Convert.ToInt32(objReader["AdminStatus"]);
                objAdmin.RoleId = Convert.ToInt32(objReader["RoleId"]);
            }
            else
            {
                objAdmin = null;
            }
            objReader.Close();
            return objAdmin;
        }
        /// <summary>
        /// 将登录信息保存在日志中  返回日志编号
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int WriteLoginLogs(LoginLogs info)
        {
            string sql = "insert into LoginLogs(LoginId,SPName,ServerName) values(@LoginId,@SPName,@ServerName); select @@identity";
            //@@IDENTITY 返回的值都会递增,返回全局变量
            SqlParameter[] param = new SqlParameter[]
            {

                new SqlParameter("@LoginId",info.LoginId ),
                new SqlParameter("@SPName",info.SPName ),
                new SqlParameter("@ServerName",info.ServerName )
            };
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql, param));
        }
        /// <summary>
        /// 将用户退出的时间保存在日志中
        /// </summary>
        /// <param name="logId"></param>
        /// <returns></returns>
        public int WriteExitTime(int logId)
        {
            string sql = "Update LoginLogs set ExitTime='{0}' where LogId={1}";
            sql = string.Format(sql, SQLHelper.GetDBServerTime(), logId);
            return SQLHelper.Update(sql);
        }

        //修改密码
        public int ModifyPwd(SysAdmin objAdmin)
        {
            string sql = "update SysAdmins set LoginPwd='{0}' where LoginId='{1}'";
            sql = string.Format(sql, objAdmin.LoginPwd, objAdmin.LoginId);
            return SQLHelper.Update(sql);
        }

       /// <summary>
       /// 获取所有管理者信息
       /// </summary>
       /// <returns></returns>
        public DataTable GetAdmins()
        {
            string sql = "select LoginId,LoginPwd,AdminName,AdminStatus,RoleId ,StatusName,RoleName ";
            sql += " from View_GetAdmins";
            return SQLHelper.GetDataSet(sql).Tables[0];
        }
        /// <summary>
        /// 增加管理员
        /// </summary>
        /// <returns></returns>
        public int AddAdmin(SysAdmin objAdmin)
        {
            string sql = "insert into SysAdmins(LoginPwd,AdminName,AdminStatus,RoleId) values('{0}','{1}',{2},{3})";
            sql = string.Format(sql, objAdmin.LoginPwd, objAdmin.AdminName, objAdmin.AdminStatus, objAdmin.RoleId);
            return SQLHelper.Update(sql);
        }

        //修改管理员信息
        public int EditAdmin(SysAdmin   objSysAdmin)
        {
            string sql = "update SysAdmins set AdminName='{0}',AdminStatus={1},RoleId={2} where LoginId='{3}' ";
            sql = string.Format(sql,objSysAdmin.AdminName ,objSysAdmin .AdminStatus ,objSysAdmin .RoleId ,objSysAdmin.LoginId);
            return SQLHelper.Update(sql);   
        }
        //禁用
        public int UpdateDisStatus(string loginId)
        {
            string sql = "update SysAdmins set AdminStatus=0 where loginId='{0}'";
            sql = string.Format(sql, loginId);
            return SQLHelper.Update(sql);
        }

        //启用
        public int UpdateEnStatus(string loginId)
        {
            string sql = "update SysAdmins set AdminStatus=1 where loginId='{0}'";
            sql = string.Format(sql, loginId);
            return SQLHelper.Update(sql);
        }

        //根据账号获取用户信息
        public SysAdmin GetByLoginId(string loginId)
        {
            string sql = "select LoginId,AdminName ,AdminStatus,RoleId from SysAdmins where LoginId='{0}'";
            sql=string .Format(sql, loginId);
            SqlDataReader objReader=SQLHelper.GetReader(sql);
            SysAdmin objSysAdmin = null;
            if (objReader.Read())
            {
                objSysAdmin = new SysAdmin()
                {
                    LoginId =Convert.ToInt32 ( objReader["LoginId"]),
                    AdminName =objReader["AdminName"].ToString (),
                    AdminStatus =Convert.ToInt32(objReader["AdminStatus"]),
                    RoleId =Convert.ToInt32 (objReader["RoleId"]),
                };
            }
            objReader.Close();
            return objSysAdmin;
        }

        ////修改商品信息
        //public int EditAdmin(SysAdmin  objSysAdmin)
        //{
        //    string sql = "update SysAdmins  set AdminName='{0}',AdminStatus={1}, RoleId={2} where LoginId='{3}' ";
        //    sql = string.Format(sql, objSysAdmin .AdminName ,objSysAdmin .AdminStatus ,objSysAdmin .RoleId ,objSysAdmin .LoginId );
        //    return SQLHelper.Update(sql);
        //}

        //获取所有用户状态
        public List<UserStatus> GetAllStatus()
        {
            string sql = "select AdminStatus,StatusName from UserStatus";
            List<UserStatus> list = new List<UserStatus>();
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                list.Add(new UserStatus()
                {
                    AdminStatus = Convert.ToInt32(objReader["AdminStatus"]),
                    StatusName = objReader["StatusName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }


        //获取所有用户角色
        public List<Role> GetAllRole()
        {
            string sql = "select RoleId,RoleName from Role";
            List<Role> list = new List<Role>();
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                list.Add(new Role()
                {
                    RoleId = Convert.ToInt32(objReader["RoleId"]),
                    RoleName = objReader["RoleName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }
    }
}
