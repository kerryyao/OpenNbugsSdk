using ONS.Entities;
using ONS.Utilities.HttpUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ONS.Helpers;

namespace ONS.APIs
{
    public class CurrentUser
    {
        /// <summary>
        /// 获取当前用户信息
        /// </summary>
        /// <returns></returns>
        public static Userinfo getInfo(string token = "")
        {
            //
            //http://open.51jyb.com/cgi-bin/ajaxLoginSystem.do?method=ajaxJybJSON_108GetUserInfoByToken&oauth_token=OAUTH_TOKEN
            var url = string.Format(@"{0}/ajaxLoginSystem.do?method=ajaxJybJSON_108GetUserInfoByToken&oauth_token={1}", Config.URL_OPENBUGS, token.GetToken());
            var ret = Get.GetJson<RetResult<Userinfo>>(url);

            if (ret.code == "0")
                return ret.r;
            else
                return null;
        }
    }
}
