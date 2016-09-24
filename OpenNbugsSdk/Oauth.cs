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
        /// <returns></returns>
        public static GetTokenResult GetToken(int timeOut = 10000)
        {
            var url = OauthHelper.GetTokenUrl(Config.ClientId, Config.ClientSecret);
            return CommonJsonSend.Send<GetTokenResult>(null, url, null, CommonJsonSendType.GET, timeOut);       //应用授权同时支持GET和POST
        }

        /// <summary>
        /// suguo.yao 2016-9-4
        /// 获取当前授权登录的用户信息及用户accesstoken
        /// </summary>
        /// <returns></returns>
        public static RetResult<Userinfo> GetTokenWithUserinfo(string code)
        {
            var url = OauthHelper.GetAccessTokenUrl(Config.ClientId, Config.ClientSecret, code);
            return CommonJsonSend.Send<RetResult<Userinfo>>(null, url, null, CommonJsonSendType.GET);
        }
    }
}
