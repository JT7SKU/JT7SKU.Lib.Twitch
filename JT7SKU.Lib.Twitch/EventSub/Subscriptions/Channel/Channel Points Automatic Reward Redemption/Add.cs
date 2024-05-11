using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.ChannelPoints;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.ChannelPoints;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Channel_Points_Automatic_Reward_Redemption
{
    internal class Add
    {
    }
    #region Channnel.Channel Points Automatic Reward Redemption.Add
    // The channel.channel_points_automatic_reward_redemption.add subscription type sends a notification
    // when a viewer has redeemed an automatic channel points reward on the specified channel.
    // Must have channel:read:redemptions or channel:manage:redemptions scope.
    public record ChannelPointsAutomaticRewardRedemptionAddRequestBody
    {

        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPointsAutomaticRewardRedemptionAddCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPointsAutomaticRewardRedemptionAddNotificationPayload
    {

        public Models.Subscription Subscription { get; set; }
        public ChannelPointsCustomRewardsAddEvent Event { get; set; }
    }
    #endregion
}
