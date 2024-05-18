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
    internal class End
    {
    }
    #region Channel.Goal.End
    // Notifies the subscriber when the specified broadcaster ends a goal.
    // Requires a user OAuth access token with scope set to channel:read:goals.
    public record ChannelGoalEndRequestBody
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
    public record ChannelGoalNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public GoalsEvent Event { get; set; }
    }
    #endregion
}
