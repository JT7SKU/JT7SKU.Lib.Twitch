using JT7SKU.Lib.Twitch.EventSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class TopContribution
    {
        public int Total { get; set; }
        public ContributionType Type { get; set; }
        public string User { get; set; }
    }
}
