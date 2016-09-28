using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ONS.tests
{
    [TestClass]
    public class OauthTest
    {
        public OauthTest()
        {
            Config.ClientId = "cf4dc7df319242f69881a149aad65275";
            Config.ClientSecret = "aaaaaaaaaaaaaaaaa";
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
            Assert.AreEqual("https://open.xiaoyuanhao.com/cgi-bin/oauth2/token?grant_type=client_credentials&client_id=cf4dc7df319242f69881a149aad65275&client_secret=aaaaaaaaaaaaaaaaa", url);
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
            Config.ClientSecret = "";  //测试时变更为实际值
            //应用授权测试
            var ret = Oauth.GetToken();
            Assert.IsNotNull(ret);
            Assert.IsTrue(ret.expires_in > 0);
        }

        [TestMethod]
        public void TestGetAccessToken()
        {
            Config.ClientSecret = "d4c253e584f54bf378b55618d7f05b998FD13D0D6C";
            string code = "eeede5a5c9a0f73f376a5735b14cae5c"; //测试时先手动获取CODE，写到这里，然后进行下面的各项测试
            var ret = Oauth.GetTokenWithUserinfo(code);
            Assert.IsNotNull(ret);
        }
    }
}
