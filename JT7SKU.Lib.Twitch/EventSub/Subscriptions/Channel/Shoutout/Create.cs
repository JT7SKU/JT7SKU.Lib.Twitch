using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Shoutout;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Shoutout;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Shoutout
{
    internal class Create
    {
    }
    #region Channel.Shoutout.Create
    // Sends a notification when the specified broadcaster sends a Shoutout.
    // Requires the moderator:read:shoutouts or moderator:manage:shoutouts scope.
    // If you use webhooks, the user in moderator_user_id must have granted your app (client ID) one of the above permissions prior to your app subscribing to
    // this subscription type. To learn more, see the Authorization section of Create EventSub Subscription.
    // If you use WebSockets, the ID in moderator_user_id must match the user ID in the user access token. 
    public record ChannelShoutoutCreateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelShoutoutCreateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelShoutoutCreateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelShoutoutCreateEvent Event { get; set; }
    }
    #endregion
}
