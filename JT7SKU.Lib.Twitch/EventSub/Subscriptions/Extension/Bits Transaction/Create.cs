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

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Extension.Bits_Transaction
{
    internal class Create
    {
    }
    #region Extension.Bits Transaction.Create
    // The extension.bits_transaction.create subscription type sends a notification when a new transaction is created for a Twitch Extension.
    // NOTE This subscription type is only supported by webhooks, and cannot be used with WebSockets.
    // The OAuth token client ID must match the Extension client ID.
    public record ExtensionBitsTransactionCreateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ExtensionBitsTransactionCreateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ExtensionBitsTransactionCreateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ExtensionBitsTransactionCreateEvent Event { get; set; }
    }
    #endregion
}
