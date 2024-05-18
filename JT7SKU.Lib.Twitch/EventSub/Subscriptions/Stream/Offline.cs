using JT7SKU.Lib.Twitch.EventSub.Events.Stream;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Stream;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Stream
{
    internal class Offline
    {
    }
    #region Stream.Offline
    // The stream.offline subscription type sends a notification when the specified broadcaster stops a stream.
    public record StreamOfflineRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public StreamOfflineCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record StreamOfflineNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public StreamOfflineEvent Event { get; set; }
    }
    #endregion
}
