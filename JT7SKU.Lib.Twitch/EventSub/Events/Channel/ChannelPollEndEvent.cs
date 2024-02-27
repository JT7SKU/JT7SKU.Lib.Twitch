using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelPollEndEvent
    {
        public string Id { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string Title { get; set; }
        public Choices Choices { get; set; }
        public BitsVoting BitsVoting { get; set; }
        public ChannelPointsVoting ChannelPointsVoting { get; set; }
        public string StartedAt { get; set; }
        public string EndsAt { get; set; }
    }
}
