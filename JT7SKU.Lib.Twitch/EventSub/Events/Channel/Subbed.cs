namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class Subbed
    {
        public SubscriberType SubTier { get; set; }
        public bool IsPrime { get; set; }
        public int DurationMonths { get; set; }
    }
}