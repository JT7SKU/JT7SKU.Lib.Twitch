using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.HypeTrain;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.HypeTrain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Hype_Train
{
    internal class Progrees
    {
    }
    #region Channel.Hype Train.Progress
    // The channel.hype_train.progress subscription type sends a notification when a Hype Train makes progress on the specified channel.
    // When a Hype Train starts, one channel.hype_train.progress event will be sent for each contribution that caused the Hype Train to begin
    // (in addition to the channel.hype_train.begin event). EventSub does not make strong assurances about the order of message delivery,
    // so it is possible to receive channel.hype_train.progress before you receive the corresponding channel.hype_train.begin.
    //After a Hype Train begins, any additional cheers or subscriptions on the channel will cause channel.hype_train.progress notifications to be sent.
    //When the Hype Train is over, channel.hype_train.end is emitted.
    // Must have channel:read:hype_train scope.
    public record ChannelHypeTrainProgressRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public HypeTrainProgressCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelHypeTrainProgressNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public HypeTrainProgressEvent Event { get; set; }
    }
    #endregion
}
