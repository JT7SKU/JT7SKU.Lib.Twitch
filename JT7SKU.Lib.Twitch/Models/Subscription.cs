using JT7SKU.Lib.Twitch.EventSub;

namespace JT7SKU.Lib.Twitch.Models
{
    public class Subscription
    {
        public string Id { get; set; }
        public SubscriberType Type { get; set; }
        public string Version { get; set; }
        public string Status { get; set; }
        public int Cost { get; set; }
        public Condition Condition { get; set; }
        public string CreatedAt { get; set; }
    }
}