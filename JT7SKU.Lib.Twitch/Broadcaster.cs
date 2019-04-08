using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    public class Broadcaster
    {
        public int Id { get; set; }
        public User User { get; set; }
        public BadgeInfo BadgeInfo { get; set; } = BadgeInfo.Broadcaster;
    }
}
