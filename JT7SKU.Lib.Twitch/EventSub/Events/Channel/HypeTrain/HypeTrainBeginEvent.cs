using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.EventSub;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.HypeTrain
{
    public class HypeTrainBeginEvent
    {
        public string Id { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public int Total { get; set; }
        public int Progress { get; set; }
        public int Goal { get; set; }
        public TopContributions TopContributions { get; set; }
        public LastContributions LastContributions { get; set; }
        public int Level { get; set; }
        public string StartedAt { get; set; }
        public string ExpiresAt { get; set; }
    }
}
