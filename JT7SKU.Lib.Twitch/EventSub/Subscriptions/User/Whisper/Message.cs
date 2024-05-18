using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.User;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.User.Whisper
{
    internal class Message
    {
    }
    #region User.Whisper.Message
    // The user.whisper.message subscription type sends a notification when a user receives a whisper. Event Triggers - Anyone whispers the specified user.
    // Must have oauth scope user:read:whispers or user:manage:whispers.
    public record UserWhisperMessageRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public WhisperReceivedCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record UserWhisperMessageNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public WhisperRecievedEvent Event { get; set; }
    }
    #endregion
}
