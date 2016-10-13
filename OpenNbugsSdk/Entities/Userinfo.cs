using System.Collections.Generic;

namespace ONS.Entities
{ 
    public class Userinfo
    {
        public string userType { get; set; }
        public string userName { get; set; }
        public string userId { get; set; }
        public string orgId { get; set; }
        public string orgUniqId { get; set; }
        public List<UserRole> userRoles { get; set; }
        public List<Card> cards { get; set; }
        public List<string> details { get; set; }
        public List<Contact> contacts { get; set; }

        public string relationDetail { get; set; }//此参数用于用户认证下code换取token时接受参数
        public string relation { get; set; }//此参数用于用户认证下code换取token时接受参数


    }
}
