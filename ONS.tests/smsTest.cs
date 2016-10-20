using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ONS.APIs;
using ONS.Entities;

namespace ONS.tests
{
    [TestClass]
    public class smsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhapp7fd8e4d8ac6041958c6701882e08f4dc1476852636552");
            SmsServices sms = new SmsServices();
            sms.MsgPush(new Entities.MsgParameter() { msgid = "32131", funcid="103", msgtype="6", parentsReceive="false", studentReceive="false", orgid= "330200-S000002", senderid="", userids= "330200-S000002-T000012", deptids="", exclude_userids="", with_subdepts="false", msg = new Picture { picUrl="", summary="", title=""} });

        }
    }
}
