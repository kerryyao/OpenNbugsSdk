using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{  
    /// <summary>
    /// 登录用户信息
    /// </summary>
    public class LoginUser
    {
        public List<Object> roles { get; set; }

        public string userType { get; set; }

        public string relationDetail { get; set; }

        public string userName { get; set; }

        public string userId { get; set; }
        public string relation { get; set; }
    }
}
