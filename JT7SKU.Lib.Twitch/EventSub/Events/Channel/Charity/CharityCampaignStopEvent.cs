using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Charity
{
    public class CharityCampaignStopEvent
    {
        public string Id { get; set; }
        public string CampaingId { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string CharityName { get; set; }
        public string CharityDescription { get; set; }
        public string CharityLogo { get; set; }
        public string CharityWebsite { get; set; }
        public Amount CurrentAmount { get; set; }
        public Amount TargetAmount { get; set; }
        public string StoppedAt { get; set; }
    }
}
