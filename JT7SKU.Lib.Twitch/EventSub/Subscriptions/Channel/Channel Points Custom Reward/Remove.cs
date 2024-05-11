using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.ChannelPoints;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.ChannelPoints;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Channel_Points_Custom_Reward
{
    internal class Remove
    {
    }
    #region Channel.Channel Points Custom Reward.Remove
    // The channel.channel_points_custom_reward.remove subscription type sends a notification when a custom channel points reward has been removed from the specified channel.
    // Must have channel:read:redemptions or channel:manage:redemptions scope.

    public record ChannelPointsCustomRewardsRemoveRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPointsCustomRewardRemoveCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPointsCustomRewardRemoveNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPointsCustomRewardsRemoveEvent Event { get; set; }
    }
    #endregion
}
