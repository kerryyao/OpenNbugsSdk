using ONS.Utilities.HttpUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 校园号尚未实现双向认证
/// </summary>
namespace ONS.CommonAPIs
{
    public class Two_wayAuthentication
    {
        public string getcode(string redirect)
        {
            //http://open.51jyb.com/cgi-bin/appgrant?slave_client_id=SLAVE_CLIENT_ID&master_app_access_token=MASTER_APP_ACCESS_TOKEN&user_access_token=USER_ACCESS_TOKEN
            string url = Helpers.OauthHelper.GetPreAuthCodeUrl(redirect);
            var temp = Get.GetJson<Entities.RetResult<string>>(url);
           
            return "0";
        }
    }
}
