using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Charity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Charity_Campaign
{
    internal class Progress
    {
    }
    #region Channel.Charity Campaign.Progress
    // Sends notifications when progress is made towards the campaign’s goal or when the broadcaster changes the fundraising goal.
    // It’s possible to receive this event before the Start event.
    // To get donation information, subscribe to the channel.charity_campaign.donate event.
    // Requires the channel:read:charity scope.
    public record ChannelCharityCampaignProgressRequestBody
    {

    }
    public record ChannelCharityCampaignProgressNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public CharityCampaignProgressEvent Event { get; set; }
    }
    #endregion
}
