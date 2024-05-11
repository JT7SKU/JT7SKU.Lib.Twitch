using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Poll;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Poll;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Polls
{
    internal class Progress
    {
    }
    #region Channel.Polls.Progress
    // The channel.poll.progress subscription type sends a notification when users respond to a poll on the specified channel.
    // Must have channel:read:polls or channel:manage:polls scope.
    public record ChannelPollsProgressRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPollProgressionCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPollProgressNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPollProgressEvent Event { get; set; }
    }
    #endregion
}
