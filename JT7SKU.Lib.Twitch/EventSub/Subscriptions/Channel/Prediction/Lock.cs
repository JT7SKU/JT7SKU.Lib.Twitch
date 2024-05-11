using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Prediction;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Prediction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Prediction
{
    internal class Lock
    {
    }
    #region Channel.Prediction.Lock
    // The channel.prediction.lock subscription type sends a notification when a Prediction is locked on the specified channel.
    // Must have channel:read:predictions or channel:manage:predictions scope.
    public record ChannelPredictionLockRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPredictionLockCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPredictionLockNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPredictionLockEvent Event { get; set; }
    }
    #endregion
}
