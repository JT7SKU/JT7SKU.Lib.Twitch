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
    internal class ClearUserMessages
    {
    }
    #region Channel.Chat.Clear User Messages
    // The channel.chat.clear_user_messages subscription type sends a notification when a moderator or bot clears all messages for a specific user.'
    // Requires user:read:chat scope from chatting user.
    // If app access token used, then additionally requires user:bot scope from chatting user, and either channel:bot scope from broadcaster or moderator status.
    public record ChannelChatClearUserMessagesRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelChatClearUserMessagesCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelChatClearUserMessagesNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelChatClearUserMessagesEvent Event { get; set; }
    }
    #endregion
}
