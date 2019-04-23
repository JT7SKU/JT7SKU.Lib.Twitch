using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    public class Message
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Context { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
