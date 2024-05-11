using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.VIP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.VIP
{
    internal class Remove
    {
    }
    #region Channel.VIP.Remove
    //  The channel.vip.remove subscription type sends a notification when a VIP is removed from the channel.
    // Must have channel:read:vips or channel:manage:vips scope.
    public record ChannelVIPRemoveRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelVIPRemoveCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelVIPRemoveNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelVIPRemoveEvent Event { get; set; }
    }
    #endregion
}
