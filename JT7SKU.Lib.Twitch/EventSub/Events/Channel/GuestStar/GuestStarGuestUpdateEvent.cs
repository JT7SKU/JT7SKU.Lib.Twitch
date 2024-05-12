using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.GuestStar
{
    public class GuestStarGuestUpdateEvent
    {
         public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string SessionId { get; set; }
        public string ModeratorUserId { get; set; }
        public string ModeratorUserName { get; set; }
        public string ModeratorLogin { get; set; }
        public string GuestStarUserId { get; set; }
        public string GuestStarUserName { get; set; }
        public string GuestStarLogin { get; set; }
        public string SlotId { get; set; }
        public string State { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string UserLogin { get; set; }
        public bool HostVideoEnabled { get; set; }
        public bool HostAudioEnabled { get; set; }
        public int HostVolume { get; set; }
    }
}
