using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.ChannelPoints;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.ChannelPoints;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Channel_Points_Custom_Reward_Redemption
{
    internal class Add
    {
    }
    #region Channel.Channel Points Custom Reward Redemption.Add
    // The channel.channel_points_custom_reward_redemption.add subscription type sends a notification when a viewer has redeemed a custom channel points reward on the specified channel.
    // Must have channel:read:redemptions or channel:manage:redemptions scope.
    public record ChannelPointsCustomRewardRedemptionAddRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPointsCustomRewardRedemptionAddCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPointsCustomRewardRedemptionAddNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPointsCustomRewardRedemptionAddEvent Event { get; set; }
    }
    #endregion
}
