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
    internal class End
    {
    }
    #region Channel.Hype Train.End
    // The channel.hype_train.end subscription type sends a notification when a Hype Train ends on the specified channel.
    // Must have channel:read:hype_train scope.
    public record ChannelHypeTrainEndRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public HypeTrainEndCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelHypeTrainEndNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public HypeTrainEndEvent Event { get; set; }
    }
    #endregion
}
