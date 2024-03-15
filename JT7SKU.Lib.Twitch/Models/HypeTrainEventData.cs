using JT7SKU.Lib.Twitch.EventSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class HypeTrainEventData
    {
        public string BroadcasterId { get; set; }
        public DateTime CooldownEndTime { get; set; }
        public DateTime ExpiresAt { get; set; }
        public int Goal {  get; set; }
        public string Id { get; set; }
        public LastContribution LastContribution { get; set; }
        public int Level { get; set; }
        public DateTime StartedAt { get; set; }
        public List<TopContribution> TopContributions { get; set; }
        public int Total { get; set; }
    }
}
