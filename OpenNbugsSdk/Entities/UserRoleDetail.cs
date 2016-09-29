using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    public class UserRoleDetail
    {
        public string userId { get; set; }
        public string orgId { get; set; }
        public string userRole { get; set; }
        public string userOrgIndicade { get; set; }
        public long inDate { get; set; }
        public string loginOrgId { get; set; }
        public Org org { get; set; }
    }
}
