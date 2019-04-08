using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    public class Message
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Context { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}
