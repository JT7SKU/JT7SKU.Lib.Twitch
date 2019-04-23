using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        // User
        public string UserId { get; set; }
        public User User { get; set; }

        // Actual Message
        public string Context { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
