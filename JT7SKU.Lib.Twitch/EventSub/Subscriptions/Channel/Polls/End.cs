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
    internal class End
    {
    }
    #region Channel.Polls.End
    // The channel.poll.end subscription type sends a notification when a poll ends on the specified channel.
    // Must have channel:read:polls or channel:manage:polls scope.
    public record ChannelPollsEndRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPollEndCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPollsEndNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPollEndEvent Event { get; set; }
    }
    #endregion
}
