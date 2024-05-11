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
    internal class Add
    {
    }
    #region Channel.VIP.Add
    //  The channel.vip.add subscription type sends a notification when a VIP is added to the channel.
    // Must have channel:read:vips or channel:manage:vips scope.
    public record ChannelVIPAddRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelVIPAddCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelVIPAddNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelVIPAddEvent Event { get; set; }
    }
    #endregion
}
