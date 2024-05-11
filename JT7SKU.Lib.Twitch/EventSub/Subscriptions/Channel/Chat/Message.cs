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
    internal class Message
    {
    }
    #region Channel.Chat.Message
    // The channel.chat.message subscription type sends a notification when any user sends a message to a specific chat room.
    // Requires user:read:chat scope from the chatting user.
    // If app access token used, then additionally requires user:bot scope from chatting user, and either channel:bot scope from broadcaster or moderator status.
    public record ChannelChatMessageRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelChatMessageCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelChatMessageNotificationPayload
    {
        public Transport Transport { get; set; }
        public ChannelChatMessageEvent Event { get; set; }
    }
    #endregion
}
