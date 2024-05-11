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
    internal class UserMessageUpdate
    {
    }
    #region Channel.Chat.User Message Update
    // he channel.chat.user_message_update subscription type notifies a user if their message’s automod status is updated.
    // Requires user:read:chat scope from chatting user. If app access token used, then additionally requires user:bot scope from chatting user.
    public record ChannelChatUserMessageUpdateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelChatUserMessageUpdate Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelChatUserMessageUpdateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelChatUserMessageUpdateEvent Event { get; set; }
    }
    #endregion
}
