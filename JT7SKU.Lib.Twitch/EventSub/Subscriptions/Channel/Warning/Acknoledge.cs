using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Moderation;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Warning;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Moderation;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Warning;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Subscriptions.Channel.Warning
{
    internal class Acknoledge
    {
    }
    #region channel.warning.acknoledge
    ///<summary> 
    ///The channel.warning.acknowledge subscription type sends a notification when a warning is acknowledged by a user. 
    ///Broadcasters and moderators can see the warning’s details.
    ///Authorization 
    ///Must have the moderator:read:warnings or moderator:manage:warnings scope.
    ///</summary>
    public record ChannelWarningAcknoledgeRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelWarningAcknoledgeCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelWarningAcknoledgeNotificationPayload
    {
        public Subscription Subscription { get; set; }
        public ChannelWarningAcknoledgeEvent Event { get; set; }
    }
    #endregion
}
