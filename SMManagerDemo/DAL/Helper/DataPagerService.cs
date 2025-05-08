using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //分页数据访问类
    public  class DataPagerService
    {
        /// <summary>
        /// 实现日志记录的分页查询
        /// </summary>
        /// <param name="pageSize">每页显示多少条记录</param>
        /// <param name="currentPage">第几页</param>
        /// <param name="recordCount">记录的总数</param>
        /// <param name="beginTime">查询的起始时间</param>
        /// <param name="endTime">查询的结束时间</param>
        /// <returns></returns>
        public DataTable QueryLog(int pageSize, int currentPage, out int recordCount, string beginTime, string endTime)
        {
            SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter ("@PageSize",pageSize),
                    new SqlParameter ("@CurrentPage",currentPage),
                    new SqlParameter ("@BeginTime",beginTime),
                    new SqlParameter ("@EndTime",endTime)
                };
            DataSet ds = SQLHelper.GetDataSetByProcedure("usp_LogDataPager",param);
            recordCount = Convert.ToInt32(ds.Tables[1].Rows[0][0]);
            return ds.Tables[0];
        }
    }
}
