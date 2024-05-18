using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Conditions.Conduit;
using JT7SKU.Lib.Twitch.EventSub.Events;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Conduit.Shard
{
    internal class Disabled
    {
    }
    #region Conduit.Shard.Dispabled
    // The conduit.shard.disabled subscription type sends a notification when EventSub disables a shard due to the status of the underlying transport changing.
    // App access token where the client ID matches the client ID in the condition. If conduit_id is specified, the client must be the owner of the conduit.
    public record ConduitShardDisabledRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ConduitShardDisabledCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ConduitShardDisabledNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ConduitShardDisabledEvent Event { get; set; }
    }
    #endregion
}
