using JT7SKU.Lib.Twitch.EventSub.Conditions;
using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Drop.Entitlement
{
    internal class Grant
    {
    }
    #region Drop.Entitlement.Grant
    // The drop.entitlement.grant subscription type sends a notification when an entitlement for a Drop is granted to a user.
    // NOTE This subscription type is only supported by webhooks, and cannot be used with WebSockets.
    // App access token required. The client ID associated with the access token must be owned by a user who is part of the specified organization.
    public record DropEntitlementGrantRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public DropEntitlementGrantCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record DropEntitlementGrantNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public DropEntitlementGrantEvent[] Events { get; set; }
    }
    #endregion
}
