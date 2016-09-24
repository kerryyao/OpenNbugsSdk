using ONS.CommonAPIs;
using ONS.Entities;
using ONS.Helpers;

namespace ONS
{
    public static class Oauth
    {
        /// <summary>
        /// suguo.yao 2016-9-24
        /// 应用授权
        /// </summary>
        /// <param name="redirectUrl">不需要做urlencode</param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public static GetTokenResult GetToken(string redirectUrl, int timeOut = 10000)
        {
            var url = OauthHelper.GetPreAuthCodeUrl(redirectUrl);
            return CommonJsonSend.Send<GetTokenResult>(null, url, null, CommonJsonSendType.POST, timeOut);
        }

        /// <summary>
        /// suguo.yao 2016-9-4
        /// 获取用户accesstoken
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static GetTokenResult GetAccessToken(string code)
        {
            var url = OauthHelper.GetAccessTokenUrl(Config.ClientId, Config.ClientSecret, code);
            return CommonJsonSend.Send<GetTokenResult>(null, url, null);
        }

        public static RetResult<GetTokenWithUserinfoResult> GetTokenWithUserinfo(string code)
        {
            var url = OauthHelper.GetAccessTokenUrl(Config.ClientId, Config.ClientSecret, code);
            return CommonJsonSend.Send<RetResult<GetTokenWithUserinfoResult>>(null, url, null);
        }
    }
}
