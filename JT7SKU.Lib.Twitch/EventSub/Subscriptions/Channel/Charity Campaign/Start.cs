using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Charity;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Charity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Charity_Campaign
{
    internal class Start
    {
    }
    #region Channel.Charity Campaign.Start
    // Sends a notification when the broadcaster starts a charity campaign.
    // It’s possible to receive this event after the Progress event.
    // Requires the channel:read:charity scope.
    public record ChannelCharityCampaignStartRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public CharityCampaignStartCondition Condition { get; set; }
        [Required]
        public string BroadcasterUserId { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelCharityCampaignStartNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public CharityCampaignStartEvent Event { get; set; }
    }
    #endregion
}
