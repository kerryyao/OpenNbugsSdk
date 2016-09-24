namespace ONS
{
    /// <summary>
    /// 全局配置类
    /// </summary>
    public static class Config
    {
        public const int TIME_OUT = 10000;
        public const string URL_OPENBUGS = @"https://open.xiaoyuanhao.com/cgi-bin";

        public static string ClientId { get; set; }
        public static string ClientSecret { get; set; }
    }
}
