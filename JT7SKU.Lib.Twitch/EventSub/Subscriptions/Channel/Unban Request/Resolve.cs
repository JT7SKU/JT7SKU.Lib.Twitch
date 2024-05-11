using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Moderation;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Moderation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Unban_Request
{
    internal class Resolve
    {
    }
    #region 
    // The channel.unban_request.resolve subscription type sends a notification when an unban request has been resolved.
    // Must have moderator:read:unban_requests or moderator:manage:unban_requests scope.
    // If you use webhooks, the user in moderator_id must have granted your app (client ID) one of the above permissions prior to your app subscribing to this subscription type.
    // To learn more, see the Authentication section of Create EventSub Subscription.
    // If you use WebSockets, the ID in moderator_id must match the user ID in the user access token.
    public record ChannelUnbanRequestResolveRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelUnbanRequestResolveCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelUnbanRequestResolveNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelUnbanEvent Event { get; set; }
    }
    #endregion
}
