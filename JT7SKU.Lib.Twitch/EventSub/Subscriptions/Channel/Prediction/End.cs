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
    internal class End
    {
    }
    #region Channel.Prediction.End
    // The channel.prediction.end subscription type sends a notification when a Prediction ends on the specified channel.
    // Must have channel:read:predictions or channel:manage:predictions scope.
    public record ChannelPredictionEndRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPredictionEnd Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPredictionEndNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPredictionEndEvent Event { get; set; }
    }
    #endregion
}
