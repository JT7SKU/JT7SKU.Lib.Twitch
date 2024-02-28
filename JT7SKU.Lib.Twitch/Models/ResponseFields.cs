using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class ResponseFields
    {
        public Subscription Subscription { get; set; }
        public Event Event { get; set; }
    }
}
