namespace ONS.Entities
{
    public class TokenResult
    {
        public string error { get; set; }
        public string error_description { get; set; }
        public string access_token { get; set; }
        public int expires_in { get; set; }
    }
}
