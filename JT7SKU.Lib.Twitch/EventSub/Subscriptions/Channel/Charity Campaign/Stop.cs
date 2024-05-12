using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Charity;
using System;
using System.Collections.Generic;
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

    }
    public record ChannelCharityCampaignStopNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public CharityCampaignStopEvent Event { get; set; }
    }
    #endregion
}
