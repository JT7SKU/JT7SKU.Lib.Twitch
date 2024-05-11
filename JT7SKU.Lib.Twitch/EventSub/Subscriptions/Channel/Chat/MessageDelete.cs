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
    internal class MessageDelete
    {
    }
    #region Channel.Chat.MessageDelete
    // The channel.chat.message_delete subscription type sends a notification when a moderator removes a specific message.
    // Requires user:read:chat scope from chatting user.
    // If app access token used, then additionally requires user:bot scope from chatting user, and either channel:bot scope from broadcaster or moderator status.
    public record ChannelChatMessageDeleteRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelChatMessageDeleteCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelChatMessageDeleteNotificationPayload
    {
        public Transport Transport { get; set; }
        public ChannelChatMessageDeleteEvent Event { get; set; }
    }

    #endregion
}
