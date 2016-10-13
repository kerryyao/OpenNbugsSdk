using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    public class BaseUser<T>
    {
        public string orgType { get; set; }

        public string orgName { get; set; }
        public string passId { get; set; }
        public string oauthToken { get; set; }
        public string orgId { get; set; }
        public List<T> users { get; set; }
        public string passType { get; set; }
        public string mobile { get; set; }

      
    }
}
