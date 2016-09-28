using ONS.Entities;
using ONS.Utilities.HttpUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.APIs
{
    public class user
    {
        public Userinfo getUserinfo(string orgid, string userid, string oauth_token, bool with_contacts, bool with_orgext, bool with_card, bool with_roledetail)
        {
            Userinfo result = null;
            string url = Config.URL_OPENBUGS + "/user/get?orgid=" + orgid + "&userid=" + userid + "&oauth_token=" + oauth_token;
            var temp = Get.GetJson<RetResult<Userinfo>>(url);
            result = temp.r;
            return result;
        }
    }
}
