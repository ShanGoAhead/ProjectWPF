using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
    public class DataPagerManager
    {
        private DataPagerService  objPagerService=new DataPagerService();

        //记录总数
        public int RecordCount { get; set; }
        //每页显示多少条
        public int PageSize { get; set; }
        //当前第多少页
        public int CurrentPage { get; set; }
        //分页的总数
        public int PageCount
        {
            get
            {
                if (RecordCount != 0)//如果记录总数不等于0
                {
                    if (RecordCount % PageSize != 0)//记录总数不能除尽每页多少条
                    {
                        return RecordCount / PageSize + 1;//分页的总数等于记录总数除以每页多少条记录 再加上1
                    }
                    else
                    {
                        return RecordCount / PageSize;//能除尽时 分页的总数等于记录总数除以每页多少条记录
                    }
                }
                else//如果记录总数等于0
                {
                    this.CurrentPage = 1;
                    return 0;//分页总数等于0
                }
            }
            
        }
        /// <summary>
        /// 实现日志记录的分页查询
        /// </summary>
        /// <param name="pageSize">每页显示多少条记录</param>
        /// <param name="currentPage">第几页</param>
        /// <param name="recordCount">记录的总数</param>
        /// <param name="beginTime">查询的起始时间</param>
        /// <param name="endTime">查询的结束时间</param>
        /// <returns></returns>
        public DataTable QueryLog(string beginTime, string endTime)
        {
            int recordCount = 0;
            DataTable dt = objPagerService.QueryLog(this.PageSize ,this.CurrentPage ,
                out recordCount ,beginTime,Convert .ToDateTime (endTime).AddDays (1.0).ToShortDateString ());
            this.RecordCount = recordCount;
            return dt;

        }
    }
}
