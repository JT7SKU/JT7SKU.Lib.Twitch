using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class UserInvite
    {
        public string UserID { get; set; }
        public DateTime InvitedAt { get; set; }
        public ChannelGuestStarState Status { get; set; }
        public bool IsVideoEnabled { get; set; }
        public bool IsAudioEnabled { get; set; }
        public bool IsVideoAvailable { get; set; }
        public bool IsAudioAvailable { get; set;
    }
}
