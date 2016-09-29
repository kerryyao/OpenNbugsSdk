using ONS.Containers;
using ONS.Entities;

namespace ONS.Helpers
{
    public static class TokenHelper
    {
        public static string GetToken(this string token)
        {
            if (!string.IsNullOrEmpty(token))
                return token;

            var t = TokenContainer.getCache<TokenResult>(Config.TokenName);
            if (t == null)
                return "";

            return t.access_token;
        }
    }
}
