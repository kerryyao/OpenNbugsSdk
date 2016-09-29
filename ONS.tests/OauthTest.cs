using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ONS.tests
{
    [TestClass]
    public class OauthTest
    {
        public OauthTest()
        {
            Config.ClientId = "a2c78eae15b74e3cb3a567f01644dbd6";
            Config.ClientSecret = "075945f6d721e1e1a4337388909009cfED6162FD8C";
        }

        [TestMethod]
        public void TestGetPreAuthCodeUrl()
        {
            //http://open.51jyb.com/cgi-bin/authorize?client_id=a2c78eae15b74e3cb3a567f01644dbd6&response_type=code&redirect_uri=http%3a%2f%2fwww.rb06.com%2faaa%2fbbb
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
            string code = "489460f5be523b8ff38447ad183a1a45"; //测试时先手动获取CODE，写到这里，然后进行下面的各项测试
            var ret = Oauth.GetToken(code, true);
            Assert.IsNotNull(ret);
            Assert.IsNotNull(ret.access_token);
            //85873eb9adf14990b181290ad6416e841475136815334
        }
    }
}
