using System;
using System.Collections.Generic;
using System.Text;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.Lib.Twitch
{
    public class Subscriber
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public User User { get; set; }
        public BadgeInfo BadgeInfo { get; set; } = BadgeInfo.Subscriber;
        public SubscriberType SubscriberType { get; set; }
        public int CumulativeMonths { get; set; }
        public int StreakMonths { get; set; }
    }
}
