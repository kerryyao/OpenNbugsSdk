using System.Collections.Generic;

namespace ONS.Entities
{
    public class Userinfo
    {
        public string usertype { get; set; }
        public string username { get; set; }
        public string userid { get; set; }
        public string orgid { get; set; }
        public string orgname { get; set; }
        public string orgtype { get; set; }
        public string orgUniqId { get; set; }
        public string passid { get; set; }
        public string acctoken { get; set; }
        public string passtype { get; set; }
        public string logintype { get; set; }
        public string sex { get; set; }
        public string roles { get; set; }
        public User user { get; set; }
        public List<Card> cards { get; set; }
        public List<UserRole> allrole { get; set; }
        public LoginContack logincontack { get; set; }

    }
}
