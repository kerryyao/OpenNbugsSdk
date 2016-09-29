using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ONS.Helpers;
using ONS.Utilities.HttpUtility;
using ONS.Entities;

namespace ONS.APIs
{
    public class Organization
    {
        public object GetOrg(string orgid,OrgType orgtype, string token = "")
        {
            //http://open.51jyb.com/cgi-bin/ajaxLoaderCommonOrgnization.do?method=ajaxJybJSON_LoadSubOrgnizations&oauth_token=OAUTH_TOKEN&orgid=ORGID&orgtype=ORGTYPE
            var url = string.Format(@"{0}/ajaxLoaderCommonOrgnization.do?method=ajaxJybJSON_LoadSubOrgnizations&oauth_token={1}&orgid={2}&orgtype={3}", Config.URL_OPENBUGS, token.GetToken(),orgid,orgtype.ToString());
            var ret = Get.GetJson<RetResult<Userinfo>>(url);
            return ret;
        }
    }
}
