using ONS.Entities;
using ONS.Utilities.HttpUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.APIs
{
    public class CurrentUser
    {
        /// <summary>
        /// 获取当前用户信息
        /// </summary>
        /// <returns></returns>
        public Userinfo getInfo()
        {
            string url = Config.URL_OPENBUGS + "/user/get?orgid=&userid=&oauth_token=";
            var ret = Get.GetJson<RetResult<Userinfo>>(url);
            if (ret.error == "0")
                return ret.r;
            else
                return null;
        }
    }
}
