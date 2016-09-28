using ONS.Utilities.HttpUtility;

namespace ONS.Helpers
{
    /// <summary>
    /// 用来生成OAUTH认证用的相关URL
    /// </summary>
    public static class OauthHelper
    {
        /// <summary>
        /// 获取预授权码
        /// </summary>
        /// <param name="redirect_url">回调地址</param>
        public static string GetPreAuthCodeUrl(string redirect_url)
        {
            //http://open.51jyb.com/cgi-bin/authorize?client_id=CLIENT_ID&response_type=code&redirect_uri=REDIRECT_URL
            return string.Format(@"{0}/authorize?client_id={1}&response_type=code&redirect_uri={2}", Config.URL_OPENBUGS, Config.ClientId, redirect_url.UrlEncode().UrlEncode());       //此处故意二次转换，服务端不知原因进行了二次解码
        } 

        /// <summary>
        /// 应用授权时获取URL
        /// </summary>
        /// <param name="clientid"></param>
        /// <param name="clientsecret"></param>
        public static string GetTokenUrl(string clientid, string clientsecret)
        {
            //http://open.51jyb.com/cgi-bin/access_token?grant_type=client_credentials&client_id=CLIENT_ID&client_secret=CLIENT_SECRET
            return string.Format(@"{0}/access_token?grant_type=client_credentials&client_id={1}&client_secret={2}", Config.URL_OPENBUGS, clientid, clientsecret);
        }


        /// <summary>
        /// 用户授权时，通过CODE获取ACCESSTOKEN时的URL
        /// access_token的有效时间为24小时
        /// </summary>
        /// <param name="clientid"></param>
        /// <param name="clientsecret"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetAccessTokenUrl(string clientid, string clientsecret, string code)
        {
            //http://open.51jyb.com/cgi-bin/access_token?client_id=CLIENT_ID&client_secret=CLIENT_SECRET&grant_type=authorization_code&code=CODE 
            return string.Format(@"{0}/access_token?client_id={1}&client_secret={2}&grant_type=authorization_code&code={3}", Config.URL_OPENBUGS, clientid, clientsecret, code);
        }
    }
}
 