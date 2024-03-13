using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public enum SubscriptionStatus
    {
        enabled,
        webhook_callback_verification_pending,
        webhook_callback_verification_failed,
        notification_failures_exceeded,
        authorization_revoked,
        moderator_removed,
        user_removed,
        version_removed,
        beta_maintenance,
        websocket_disconnected,
        websocket_failed_ping_pong,
        websocket_received_inbound_traffic,
        websocket_connection_unused,
        websocket_internal_error,
        websocket_network_timeout,
        websocket_network_error
    }
}
