using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelChatNotificationEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string ChatterUserId { get; set; }
        public string ChatterUserName { get; set; }
        public string ChatterUserLogin { get; set; }
        public bool ChatterIsAnonymous { get; set; }
        public string Color { get; set; }
        public ChatBadges Badges { get; set; }
        public string SystemMessage { get; set; }
        public string MessageId { get; set; }
        public ChatMessage Message { get; set; }
        public string NoticeType { get; set; }
        public Subbed Sub { get; set; }
        public Resub Resub { get; set; }
        public CommunitySubGift CommunitySubGift { get; set; }
        public GiftPaidUpgrade GiftPaidUpgrade { get; set; }
        public PrimePaidUpgrade PrimePaidUpgrade { get; set; }
        public Raid Raid { get; set; }
        public Raid UnRaid { get; set; } = null;
        public PayItForward PayItForward { get; set; }
        public Announcement Announcement { get; set; }
        public CharityDonation CharityDonation { get; set; }
        public BitsBadgeTier BitsBadgeTier { get; set; }


    }
}
