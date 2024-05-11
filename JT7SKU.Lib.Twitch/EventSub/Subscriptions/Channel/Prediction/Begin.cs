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
    internal class Begin
    {
    }
    #region Channel.Prediction.Begin
    // The channel.prediction.begin subscription type sends a notification when a Prediction begins on the specified channel.
    // Must have channel:read:predictions or channel:manage:predictions scope.
    public record ChannelPredictionBeginRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPredictionBeginCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPredictionBeginNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPredictionBeginEvent Event { get; set; }
    }
    #endregion
}
