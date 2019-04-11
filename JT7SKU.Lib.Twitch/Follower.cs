using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    public class Follower
    {
        public int Id { get; set; }
        public DateTime FollowedAt { get; set; }
        public User User { get; set; }
        public User Follow { get; set; }
    }
}
