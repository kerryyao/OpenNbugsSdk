using Microsoft.VisualStudio.TestTools.UnitTesting;
using ONS.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.tests
{
    [TestClass]
    public class CurrentUserTest
    {
        private static string token = "85873eb9adf14990b181290ad6416e841475136815334";

        [TestMethod]
        public void TestCurrentUser()
        {
            var ui = CurrentUser.getInfo(token);
            Assert.IsNotNull(ui);
            Assert.IsNotNull(ui.acctoken);
        }
    }
}
