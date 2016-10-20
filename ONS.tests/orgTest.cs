using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ONS.APIs;

namespace ONS.tests
{
    [TestClass]
    public class orgTest
    {
        OrgServices org = new OrgServices();
        [TestMethod]
        public void TestMethod1()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid= Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhappd71ef9f4a64e4430afda6282a34ef0831476929099033");
            org.Orginfo("330108-S000001", "330108-S000001-Y0003-20150002");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhappd71ef9f4a64e4430afda6282a34ef0831476929099033");
            org.OrginfoList("330108-S000001", "330108-S000001-Y0003-20150002");
        }

        [TestMethod]
        public void TestMethod3()
        {
                Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhapp73151fc74761463f941fc8bfa5a5c6d31476672106447");
            org.OrgSubmit("330108-S000001", "330108-S000001-Y0003-20150002", "", "true");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhappd71ef9f4a64e4430afda6282a34ef0831476929099033");
            org.OrgTree("330108-S000001");
        }

        [TestMethod]
        public void TestMethod5()
        {

            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhappd71ef9f4a64e4430afda6282a34ef0831476929099033");
            org.orgext("330108-S000001","");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Oauth.token = new System.Collections.Generic.Dictionary<string, string>();
            Config.guid = Guid.NewGuid().ToString();
            Oauth.token.Add(Config.guid, "xyhappd71ef9f4a64e4430afda6282a34ef0831476929099033");
            org.orgcfg("330108-S000001");
        }
    }
 
}
