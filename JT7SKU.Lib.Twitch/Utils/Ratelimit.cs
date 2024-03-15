namespace JT7SKU.Lib.Twitch.Utils
{
    public class Ratelimit 
    {
        public AccountType AccountType { get; set; } 
        public int LimitPerMin {  get; set; } 
        public int LimitPerHour {get; set; } 
    }
}
