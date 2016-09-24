using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ONS.tests
{
    [TestClass]
    public class OauthTest
    {
        public OauthTest()
        {
            Config.ClientId = "111111111111111111";
            Config.ClientSecret = "aaaaaaaaaaaaaaaaa";
        }

        [TestMethod]
        public void TestGetPreAuthCodeUrl()
        {

            var url = Helpers.OauthHelper.GetPreAuthCodeUrl("http://aaa.bbb.com/aaaa/bbbb");
            Assert.AreEqual("https://open.xiaoyuanhao.com/cgi-bin/oauth2/user/authorize?client_id=111111111111111111&response_type=code&redirect_uri=http%3a%2f%2faaa.bbb.com%2faaaa%2fbbbb", url);
        }

        [TestMethod]
        public void TestGetTokenUrl()
        {
            var url = Helpers.OauthHelper.GetTokenUrl(Config.ClientId, Config.ClientSecret);
            Assert.AreEqual("https://open.xiaoyuanhao.com/cgi-bin/oauth2/token?grant_type=client_credentials&client_id=111111111111111111&client_secret=aaaaaaaaaaaaaaaaa", url);
        }

        [TestMethod]
        public void TestGetAccessTokenUrl()
        {
            var code = "afdasdasdasdasdasdasdassdfgsdfsdfsdfsdf";
            var url = Helpers.OauthHelper.GetAccessTokenUrl(Config.ClientId, Config.ClientSecret, code);
            Assert.AreEqual("https://open.xiaoyuanhao.com/cgi-bin/loginuser/loadbycode?client_id=111111111111111111&client_secret=aaaaaaaaaaaaaaaaa&code=afdasdasdasdasdasdasdassdfgsdfsdfsdfsdf", url);
        }
    }
}
