using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
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
    internal class Create
    {
    }
    #region Channel.Unban Request.Create
    //  The channel.unban_request.create subscription type sends a notification when a user creates an unban request.
    // Must have moderator:read:unban_requests or moderator:manage:unban_requests scope.
    public record ChannelUnbannRequestCreateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelUnBanRequestCreateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelUnbanRequestCreateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelUnbanEvent Event { get; set; }
    }
    #endregion
}
