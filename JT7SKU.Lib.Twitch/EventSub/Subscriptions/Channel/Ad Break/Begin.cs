using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.AdBreak;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.AddBreak;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Ad_Break
{
    internal class Begin
    {
    }
    #region Channel.Ad Break.Begin
    // The channel.ad_break.begin subscription type sends a notification when a user runs a midroll commercial break, either manually or automatically via ads manager.
    // Must have channel:read:ads scope.
    public record ChannelAdBreakBeginRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelAdBreakCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelAdBreakBeginNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelAdBreakEvent Event { get; set; }
    }

    #endregion
}
