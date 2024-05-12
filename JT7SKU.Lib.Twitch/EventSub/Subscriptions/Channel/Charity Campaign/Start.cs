using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Charity;
using System;
using System.Collections.Generic;
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

    }
    public record ChannelCharityCampaignStartNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public CharityCampaignStartEvent Event { get; set; }
    }
    #endregion
}
