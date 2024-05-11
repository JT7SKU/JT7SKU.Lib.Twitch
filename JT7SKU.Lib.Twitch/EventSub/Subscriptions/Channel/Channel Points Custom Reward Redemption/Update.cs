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
    internal class Update
    {
    }
    #region Channel.Channel Points Custom Reward Redemption.Update
    // The channel.channel_points_custom_reward_redemption.update subscription type sends a notification when a redemption of a channel points custom reward has been updated for the specified channel.
    // Must have channel:read:redemptions or channel:manage:redemptions scope.
    public record ChannelPointsCustomRewardRedemptionUpdateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelPointsCustomRewardRedemptionUpdateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelPointsCustomRewardRedemptionUpdateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelPointsCustomRewardRedemptionUpdateEvent Event { get; set; }
    }

    #endregion
}
