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
    internal class UserMessageHold
    {
    }
    #region Channel.Chat.User Message Hold
    // The channel.chat.user_message_hold subscription type notifies a user if their message is caught by automod.
    // Requires user:read:chat scope from chatting user. If app access token used, then additionally requires user:bot scope from chatting user.
    public record UserMessageHoldRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelChatUserMessageHoldCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record UserMessageHoldNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelChatUserMessageHoldEvent Event { get; set; }
    }
    #endregion
}
