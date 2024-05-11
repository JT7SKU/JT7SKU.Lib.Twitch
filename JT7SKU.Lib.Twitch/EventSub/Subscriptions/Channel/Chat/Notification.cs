using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Chat;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Chat
{
    internal class Notification
    {
    }
    #region Channel.Chat.Notification
    // The channel.chat.notification subscription type sends a notification when an event that appears in chat occurs,
    // such as someone subscribing to the channel or a subscription is gifted.
    // Requires user:read:chat scope from chatting user.
    // If app access token used, then additionally requires user:bot scope from chatting user, and either channel:bot scope from broadcaster or moderator status.
    public record ChannelChatNotificationRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelChatNotificationCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelChatNotificationNotificationPayload
    {
        public Transport Transport { get; set; }
        public ChannelChatNotificationEvent Event { get; set; }
    }
    #endregion
}
