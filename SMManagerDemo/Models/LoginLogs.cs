using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public  class LoginLogs
    {
        public int LogId { get; set; }
        public int LoginId { get; set; }
        public string SPName { get; set; }
        public string ServerName { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime  ExitTime { get; set; }
    }
}
