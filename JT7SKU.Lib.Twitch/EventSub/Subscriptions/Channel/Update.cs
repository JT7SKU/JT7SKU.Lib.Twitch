using JT7SKU.Lib.Twitch.Models;
using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel
{
    #region Channel.Update
    // The channel.update subscription type sends notifications when a broadcaster updates the category,
    // title, content classification labels, or broadcast language for their channel.
    public record ChannelUpdateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelUpdateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelUpdateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelUpdateEvent Event { get; set; }
    }
    #endregion
    

}
