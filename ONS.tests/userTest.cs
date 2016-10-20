using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ONS.APIs;

namespace ONS.tests
{
    [TestClass]
    public class userTest
    {
        UserServices user = new UserServices();
        [TestMethod]
        public void TestMethod1()
        {
         
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhappd71ef9f4a64e4430afda6282a34ef0831476929099033");
            user.getDeptidsUserinfo("330108-S000001", "330108-S000001-Y0003-20150002", "", "true", "true", "true", "true");
        }

        [TestMethod]
        public void TestMethod2()
        {

            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhapp73151fc74761463f941fc8bfa5a5c6d31476672106447");
            user.getOrgUser("330108-S000001", "330108-S000001-Y0003-20150002", "",  "true", "true", "true", "true");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhapp73151fc74761463f941fc8bfa5a5c6d31476672106447");
            user.getOrgUserByPage("330108-S000001", "330108-S000001-Y0003-20150002", "","1","50", "true", "true", "true", "true");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhapp73151fc74761463f941fc8bfa5a5c6d31476672106447");
            user.getUserInfo("330108-S000001", "330108-S000001-S20150832", true, true, true, true);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhapp52ab0464866c44c1bc6a0397e5350d591476753462253");
            user.getUserinfobyOrg("330108-S000001", "","1","10", "true", "true", "true", "true");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhapp52ab0464866c44c1bc6a0397e5350d591476753462253");
            user.getUserInfoList("330108-S000001", "330108-S000001-S20150832", true, true, true, true);
        }
    }
}
