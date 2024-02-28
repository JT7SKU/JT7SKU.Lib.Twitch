using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelGuestStarSettingsUpdateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public bool IsModeratorSentLiveEnabled { get; set; }
        public int SlotCount { get; set; }
        public bool IsBrowserSourceAudioEnabled { get; set; }
        public GroupLayout GroupLayout { get; set; }
    }
}
