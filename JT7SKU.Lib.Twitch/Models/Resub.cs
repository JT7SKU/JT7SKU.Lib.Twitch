using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class Resub
    {
        public int CumulativeMonts { get; set; }
        public int DurationMonths { get; set; }
        public int StreakMonths { get; set; }
        public SubscriberType SubTier { get; set; }
        public bool IsPrime { get; set; }
        public bool IsGift { get; set; }
        public bool GifterIsAnonymous { get; set; }
        public string GifterUserId { get; set; }
        public string GifterUsername { get; set; }
        public string GifterUserLogin { get; set; }
    }
}
