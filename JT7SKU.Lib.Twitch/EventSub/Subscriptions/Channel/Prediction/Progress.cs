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
    internal class Progress
    {
    }
    #region Channel.Prediction.Progress
    // The channel.prediction.progress subscription type sends a notification when users participate in a Prediction on the specified channel.
    // Must have channel:read:predictions or channel:manage:predictions scope.
    public record ChannelPredictionProgressRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPredictionProgressCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPredictionProgressNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPredictionProgressEvent Event { get; set; }
    }
    #endregion
}
