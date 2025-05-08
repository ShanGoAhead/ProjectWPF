using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class UserStatus
    {
        
        public int AdminStatus { get; set; }//0表示禁用  1表示启用
        public string StatusName { get; set; }
    }
}
