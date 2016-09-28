using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ONS.tests
{
    [TestClass]
    public class OauthTest
    {
        public OauthTest()
        {
            Config.ClientId = "ea978e44fd2f49e49a30e3dacad29bee";
            Config.ClientSecret = "47bb6580a852e94cd51cef436c1cc7a7BF88364F8C";
        }

        [TestMethod]
        public void TestGetPreAuthCodeUrl()
        {
            //http://open.51jyb.com/cgi-bin/authorize?client_id=ea978e44fd2f49e49a30e3dacad29bee&response_type=code&redirect_uri=http%3a%2f%2fwww.rb06.com%2faaa%2fbbb
            var redirect = "http://www.rb06.com/aaa/bbb";
            var url = Helpers.OauthHelper.GetPreAuthCodeUrl(redirect);
            Assert.AreEqual("http://open.51jyb.com/cgi-bin/authorize?client_id=ea978e44fd2f49e49a30e3dacad29bee&response_type=code&redirect_uri=http%253a%252f%252fwww.rb06.com%252faaa%252fbbb", url);
        }

        [TestMethod]
        public void TestGetTokenUrl()
        {
            var url = Helpers.OauthHelper.GetTokenUrl(Config.ClientId, Config.ClientSecret);
            Assert.AreEqual("http://open.51jyb.com/cgi-bin/access_token?grant_type=client_credentials&client_id=ea978e44fd2f49e49a30e3dacad29bee&client_secret=47bb6580a852e94cd51cef436c1cc7a7BF88364F8C", url);
        }

        [TestMethod]
        public void TestGetToken()
        {
            //应用授权测试
            var ret = Oauth.GetToken();
            Assert.IsNotNull(ret);
            Assert.IsTrue(ret.expires_in > 0);
        }

        [TestMethod]
        public void TestGetAccessToken()
        {
            string code = "351d887259208afd7887c40b7a562aca"; //测试时先手动获取CODE，写到这里，然后进行下面的各项测试
            var ret = Oauth.GetToken(code);
            Assert.IsNotNull(ret);
            Assert.IsNotNull(ret.access_token);
        }
    }
}
