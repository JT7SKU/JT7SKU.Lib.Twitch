using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class CommunitySubGift
    {
        public string Id { get; set; }
        public int Total { get; set; }
        public SubscriberType SubTier { get; set; }
        public int CumulativeTotal { get; set; }
    }
}
