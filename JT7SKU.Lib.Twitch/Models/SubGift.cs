using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class SubGift
    {
        public int DurationMonths { get; set; }
        public int CumulativeTotal { get; set; }
        public string RecipientUserId { get; set; }
        public string RecipientUserName { get; set; }
        public string RecipientUserLogin { get; set; }
        public SubscriberType SubTier { get; set; }
        public string CommunitySubGiftId { get; set; }
    }
}
