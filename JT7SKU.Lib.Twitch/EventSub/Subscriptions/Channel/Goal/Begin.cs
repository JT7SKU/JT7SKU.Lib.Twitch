using JT7SKU.Lib.Twitch.EventSub.Conditions;
using JT7SKU.Lib.Twitch.EventSub.Events;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Goal;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Goal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Goal
{
    internal class Begin
    {
    }
    #region Channel.Goal.Begin
    // Notifies the subscriber when the specified broadcaster begins a goal.
    // NOTE: It’s possible to receive the Begin event after receiving Progress events.
    // Requires a user OAuth access token with scope set to channel:read:goals.
    public record ChannelGoalBeginRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public GoalsCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelGoalBeginNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public GoalsEvent Event { get; set; }
    }
    #endregion
}
