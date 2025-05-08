using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace DAL
{
    /// <summary>
    /// 通用数据访问类（完整版）
    /// </summary>
     class SQLHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        #region 执行格式化的SQL语句
        /// <summary>
        /// 执行增、删、改SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>受影响的行数</returns>
        public static int Update(string sql)
        {
            SqlConnection conn=new SqlConnection(connString);
            SqlCommand cmd=new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //将错误信息写入日志
                WriteErrorLog("执行Update(string sql)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 获取单一结果
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>返回一切类型的结果</returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn=new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //把错误信息写入日志
                WriteErrorLog("执行GetSingleResult(string sql)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 返回一个结果集的查询（只读结果集）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn=new SqlConnection(connString);
            SqlCommand cmd=new SqlCommand(sql,conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //把错误信息写入日志文件
                WriteErrorLog("执行GetReader(string sql)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// 返回一个数据集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn=new SqlConnection(connString);
            SqlCommand cmd=new SqlCommand(sql,conn);
            SqlDataAdapter  da=new SqlDataAdapter(cmd);//创建数据适配器对象
            DataSet ds = new DataSet();//创建内存数据集
            try
            {
                conn.Open();
                da.Fill(ds);//使用数据适配器填充数据集
                return ds;//返回数据集
            }
            catch (Exception ex)
            {
                //将错误信息写入日志
                WriteErrorLog("执行GetDataSet(string sql)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// 同时执行多条查询语句，并将结果填充到对应的DateTable里面，读取时可以依据表的名称访问DataTable
        /// </summary>
        /// <param name="sqlDic">使用hashtable类型的泛型集合封装对一个SQL语句和数据表名称</param>
        /// <returns>返回一个包含若干个数据表的数据集</returns>
        public static DataSet GetDataSet(Dictionary<string, string> sqlDic)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                foreach (string tableName in sqlDic.Keys)
                {
                    cmd.CommandText = sqlDic[tableName];
                    da.Fill(ds, tableName);
                }
                return ds;
            }
            catch (Exception ex)
            {
                //将错误信息写入日志
                WriteErrorLog("执行GetDataSet(Dictionary<string, string> sqlDic)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// 基于ADO.NET事务提交多条增删改SQL语句
        /// </summary>
        /// <param name="sqlList">SQL语句集合</param>
        /// <returns>返回是否成功</returns>
        public static bool UpdateByTran(List<string> sqlList)
        {
            SqlConnection conn=new SqlConnection(connString);
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = conn;
            try
            {
                cmd.Transaction = conn.BeginTransaction();//开启事务
                foreach (string sqlItem in sqlList)
                {
                    cmd.CommandText = sqlItem;
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();//提交事务
                return true;
            }
            catch (SqlException ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//事务回滚
                }
                //将错误信息写入日志
                WriteErrorLog("执行UpdateByTran(List<string> sqlList)方法时发生错误，具体信息：" + ex.Message);
                throw new Exception("执行UpdateByTran(List<string> sqlList)方法时发生错误，具体信息：" + ex.Message);

            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;//清空事务
                }
                conn.Close();
            }
        }

        #endregion

        #region 执行带参数的SQL语句
        /// <summary>
        /// 执行增、删、改SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql, SqlParameter[] param )
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);//添加参数
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //将错误信息写入日志
                WriteErrorLog("执行Update(string sql, SqlParameter[] param )方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 获取单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //把错误信息写入日志
                WriteErrorLog("执行GetSingleResult(string sql)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 返回一个结果集的查询（只读结果集）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql, SqlParameter[] param )
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters .AddRange (param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //把错误信息写入日志文件
                WriteErrorLog("执行GetReader(string sql, SqlParameter[] param )方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
        }


        #endregion

        #region 调用存储过程
        public static int UpdateByProcedure(string storeProcedureName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand(storeProcedureName, conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storeProcedureName;//告诉Command对象，当前操作是执行存储过程
            try
            {
                conn.Open();
                if(param != null)
                 
                {
                    cmd.Parameters.AddRange(param);//添加参数
                }
               
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //将错误信息写入日志
                WriteErrorLog("执行UpdateByProcedure(string storeProcedureName, SqlParameter[] param)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 获取单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResultByProcedure(string storeProcedureName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storeProcedureName;//告诉Command对象，当前操作是执行存储过程
            try
            {
                conn.Open();
                if(param !=null)
                {
                    cmd.Parameters.AddRange(param);
                }
              
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //把错误信息写入日志
                WriteErrorLog("执行GetSingleResultByProcedure(string storeProcedureName, SqlParameter[] param)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 返回一个结果集的查询（只读结果集）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReaderByProcedure(string storeProcedureName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storeProcedureName;//告诉Command对象，当前操作是执行存储过程
            try
            {
                conn.Open();
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //把错误信息写入日志文件
                WriteErrorLog("执行GetReaderByProcedure(string storeProcedureName, SqlParameter[] param)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
        }
        public static DataSet GetDataSetByProcedure(string storeProcedureName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storeProcedureName;//告诉Command对象，当前操作是执行存储过程
            SqlDataAdapter da = new SqlDataAdapter(cmd);//创建数据适配器对象
            DataSet ds = new DataSet();//创建内存数据集
            try
            {
                conn.Open();
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                da.Fill(ds);//使用数据适配器填充数据集
                return ds;//返回数据集
            }
            catch (Exception ex)
            {
                //将错误信息写入日志
                WriteErrorLog("执行GetDataSet(string sql)方法时发生错误，具体信息：" + ex.Message);
                throw ex;
            }
        }

        #endregion

        #region 获取数据库服务器时间、将错误信息写入日志
        /// <summary>
        /// 获取数据库服务器的时间
        /// </summary>
        /// <returns></returns>
        public  static DateTime GetDBServerTime()
        {
            string sql = "select getdate()";
            return Convert.ToDateTime(GetSingleResult(sql));
        }
        /// <summary>
        /// 将错误信息写入日志
        /// </summary>
        /// <param name="msg"></param>
        private static void WriteErrorLog(string msg)
        {
            FileStream fs = new FileStream("SMManagerDemo.log", FileMode.Append);
            StreamWriter  sw=new StreamWriter(fs);
            sw.WriteLine("["+(GetDBServerTime()).ToString ()+ "]错误信息" + msg);
            sw.Close();
            fs.Close();
        }


        #endregion
    }
}
