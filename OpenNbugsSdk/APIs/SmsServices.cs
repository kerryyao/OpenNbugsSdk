using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ONS.Entities;
using ONS.Utilities.HttpUtility;
using System.IO;
using static ONS.Entities.MsgParameter;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ONS.APIs
{
    public class SmsServices
    {
        /// <summary>
        /// 信息推送，文本和图文皆可用
        /// </summary>
        /// <param name="msgparamter">信息类，图文时msg中使用picture类，文字时使用匿名类例如{ msgid = "32131", funcid="103", msgtype="6", parentsReceive="false", studentReceive="false", orgid= "330200-S000002", senderid="", userids= "330200-S000002-T000012", deptids="", exclude_userids="", with_subdepts="false", msg = new Picture { picUrl="", summary="", title=""} }</param>
        /// <returns></returns>
        public RetResult<object> MsgPush(MsgParameter msgparamter)
        {
            RetResult<object> result = null;
            string url = Config.URL_OPENBUGS + "/msg/pusher/batch?oauth_token=" + Oauth.token[Config.guid];
            var temp = RequestUtility.PostWebRequest(url, JsonConvert.SerializeObject(msgparamter), Encoding.UTF8, null);
            result = JsonConvert.DeserializeObject<RetResult<object>>(temp);
            return result;
        }
    }
}
