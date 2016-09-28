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
        /// <param name="suiteAccessToken"></param>
        /// <param name="suiteId">应用套件id</param>
        /// <param name="timeOut">代理请求超时时间（毫秒）</param>
        /// <returns></returns>
        public static string GetPreAuthCodeUrl(string redirect_url)
        {
            //https://open.xiaoyuanhao.com/cgi-bin/oauth2/user/authorize?client_id=CLIENT_ID&response_type=code&redirect_uri=REDIRECT_URL
            return string.Format(@"{0}/oauth2/user/authorize?client_id={1}&response_type=code&redirect_uri={2}", Config.URL_OPENBUGS, Config.ClientId, redirect_url.UrlEncode());
        }

        /// <summary>
        /// 应用授权时获取URL
        /// </summary>
        /// <param name="clientid"></param>
        /// <param name="clientsecret"></param>
        public static string GetTokenUrl(string clientid, string clientsecret)
        {
            
            //https://open.xiaoyuanhao.com/cgi-bin/oauth2/token?grant_type=client_credentials&client_id=CLIENT_ID&client_secret=CLIENT_SECRET 
            return string.Format(@"{0}/oauth2/token?grant_type=client_credentials&client_id={1}&client_secret={2}", Config.URL_OPENBUGS, clientid, clientsecret);
        }


        /// <summary>
        /// 用户授权时，通过CODE获取ACCESSTOKEN时的URL
        /// </summary>
        /// <param name="clientid"></param>
        /// <param name="clientsecret"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetAccessTokenUrl(string clientid, string clientsecret, string code)
        {
            //https://open.xiaoyuanhao.com/cgi-bin/loginuser/loadbycode?client_id=CLIENT_ID&client_secret=CLIENT_SECRET&code=CODE 
            return string.Format(@"{0}/loginuser/loadbycode?client_id={1}&client_secret={2}&code={3}", Config.URL_OPENBUGS, clientid, clientsecret, code);
        }
    }
}
 