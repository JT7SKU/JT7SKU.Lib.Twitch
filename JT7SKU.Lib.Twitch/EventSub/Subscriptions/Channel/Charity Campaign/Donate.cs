using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
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
    internal class Donate
    {
    }
    #region Channel.Charity.Campaign.Donate
    // Sends a notification when a user donates to the broadcaster’s charity campaign.
    // Requires the channel:read:charity scope.
    public record ChannelCharityCampaignDonateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public CharityDonationCondition Condition { get; set; }
        [Required]
        public string BroadcasterUserId { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelCharityCampaignDonateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public CharityDonationEvent Event { get; set; }
    }
    #endregion
}
