namespace JT7SKU.Lib.Twitch.Models
{
    public class Subbed
    {
        public SubscriberType SubTier { get; set; }
        public bool IsPrime { get; set; }
        public int DurationMonths { get; set; }
    }
}