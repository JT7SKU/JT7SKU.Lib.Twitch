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
    internal class Stop
    {
    }
    #region Channel.Charity Campaign.Stop
    // Sends a notification when the broadcaster stops a charity campaign.
    // Requires the channel:read:charity scope.
    public record ChannelCharityCampaignStopRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public CharityCampaignStopCondition Condition { get; set; }
        [Required]
        public string BroadcasterUserId { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelCharityCampaignStopNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public CharityCampaignStopEvent Event { get; set; }
    }
    #endregion
}
