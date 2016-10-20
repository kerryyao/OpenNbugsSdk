using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ONS.tests
{
    [TestClass]
    public class oauthTest
    {
        public oauthTest()
        {
            Config.ClientId = "56dd1c3cec6545a9acaee0c2c9ca9d02";
            Config.ClientSecret = "95bd18ccb7162bfe2dee544010cbe080A2E1184B26";
        }

        [TestMethod]
        public void TestGetPreAuthCodeUrl()
        {
            //http://open.51jyb.com/cgi-bin/authorize?client_id=cf4dc7df319242f69881a149aad65275&response_type=code&redirect_uri=http%3a%2f%2fwww.rb06.com%2faaa%2fbbb
            var redirect = "http://www.rb06.com/aaa/bbb";
            var url = Helpers.OauthHelper.GetPreAuthCodeUrl(redirect);
            Assert.AreEqual("https://open.xiaoyuanhao.com/cgi-bin/oauth2/user/authorize?client_id=cf4dc7df319242f69881a149aad65275&response_type=code&redirect_uri=http%3a%2f%2fwww.rb06.com%2faaa%2fbbb", url);
        }

        [TestMethod]
        public void TestGetTokenUrl()
        {
            var url = Helpers.OauthHelper.GetTokenUrl(Config.ClientId, Config.ClientSecret);
            Assert.AreEqual("https://open.xiaoyuanhao.com/cgi-bin/oauth2/token?grant_type=client_credentials&client_id=cf4dc7df319242f69881a149aad65275&client_secret=47bb6580a852e94cd51cef436c1cc7a7BF88364F8C", url);
        }

        [TestMethod]
        public void TestGetAccessTokenUrl()
        {
            var code = "afdasdasdasdasdasdasdassdfgsdfsdfsdfsdf";
            var url = Helpers.OauthHelper.GetAccessTokenUrl(Config.ClientId, Config.ClientSecret, code);
            Assert.AreEqual("https://open.xiaoyuanhao.com/cgi-bin/loginuser/loadbycode?client_id=cf4dc7df319242f69881a149aad65275&client_secret=aaaaaaaaaaaaaaaaa&code=afdasdasdasdasdasdasdassdfgsdfsdfsdfsdf", url);
        }

        [TestMethod]
        public void TestGetToken()
        {
            Config.ClientSecret = "47bb6580a852e94cd51cef436c1cc7a7BF88364F8C";  //测试时变更为实际值
            //应用授权测试
            var ret = Oauth.GetToken();
            Assert.IsNotNull(ret);
            Assert.IsTrue(ret.expires_in > 0);
        }

        [TestMethod]
        public void TestGetAccessToken()
        {
            Config.ClientSecret = "95bd18ccb7162bfe2dee544010cbe080A2E1184B26";
            string code = "da0e8e83d60648bbad11a39b76d503d61475909593978"; //测试时先手动获取CODE，写到这里，然后进行下面的各项测试
            var ret = Oauth.GetTokenWithUserinfo(code);
            Assert.IsNotNull(ret);
        }
    }
}
