using ONS.CommonAPIs;
using ONS.Containers;
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
        public static TokenResult GetToken(int timeOut = 10000)
        {
            var url = OauthHelper.GetTokenUrl(Config.ClientId, Config.ClientSecret);
            return CommonJsonSend.Send<TokenResult>(null, url, null, CommonJsonSendType.GET, timeOut);       //应用授权同时支持GET和POST
        }

        /// <summary>
        /// suguo.yao 2016-9-4
        /// 获取当前授权登录的用户accesstoken
        /// </summary>
        /// <returns></returns>
        public static TokenResult GetToken(string code, bool hold = false, int timeOut = 10000)
        {
            var url = OauthHelper.GetAccessTokenUrl(Config.ClientId, Config.ClientSecret, code);
            var ret = CommonJsonSend.Send<TokenResult>(null, url, null, CommonJsonSendType.GET, timeOut);
            if (!string.IsNullOrEmpty(ret.access_token) && hold)
            {
                //写入memory
                TokenContainer.setCache<TokenResult>(Config.TokenName, ret);
            }
            return ret;
        }
    }
}
