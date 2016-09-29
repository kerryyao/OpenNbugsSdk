using System.Collections.Generic;

namespace ONS.Entities
{
    public class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string usertype { get; set; }
        public string sex { get; set; }
        public List<UserRoleDetail> userRoleDetail { get; set; }
        public Org loginOrg { get; set; }
        public string loginOrgId { get; set; }
    }
}
