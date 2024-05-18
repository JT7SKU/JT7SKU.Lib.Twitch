using JT7SKU.Lib.Twitch.EventSub.Events.Stream;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Goal;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Stream;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Goal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Stream
{
    internal class Online
    {
    }
    #region Stream.Online
    // The stream.online subscription type sends a notification when the specified broadcaster starts a stream.
    public record StreamOnlineRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public StreamOnlineCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record StreamOnlineNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public StreamOnlineEvent Event { get; set; }
    }
    #endregion
}
