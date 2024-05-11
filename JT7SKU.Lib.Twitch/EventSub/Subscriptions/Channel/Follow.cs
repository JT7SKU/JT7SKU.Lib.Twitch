using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel
{
    internal class Follow
    {
    }
    #region Channel Follow
    // The channel.update subscription type sends notifications when a broadcaster updates the category,
    // title, content classification labels, or broadcast language for their channel.
    public record ChannelFollowRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelFollowCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelFollowNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelFollowEvent Event { get; set; }
    }
    #endregion
}
