using System;

namespace ONS
{
    /// <summary>
    /// 全局配置类
    /// </summary>
    public static class Config
    {
        public const int TIME_OUT = 10000;
        public const string URL_OPENBUGS = @"http://open.51jyb.com/cgi-bin";

        static Config()
        {
            TokenName = Guid.NewGuid().ToString("N").Replace("-", "");
        }

        public static string ClientId { get; set; }
        public static string ClientSecret { get; set; }
        public static string TokenName { get; set; }
    }
}
