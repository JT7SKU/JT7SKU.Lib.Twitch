using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
   public class Tip
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Double Amount { get; set; }
        public Message Message { get; set; }
    }
}
