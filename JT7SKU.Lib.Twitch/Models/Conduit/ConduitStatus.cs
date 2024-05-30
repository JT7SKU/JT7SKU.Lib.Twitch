using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Conduit
{
    public enum ConduitStatus
    {
        Enabled,
        WebhookCallbackVerificationPending,
        WebhookCallbackVerificationFailed,
        NotificationFailuresExceeded,
        WebsocketDisconnected,
        WebsocketFailedPingPong,
        WebsocketReceivedInboundTraffic,
        WebsocketInternalError,
        WebsocketNetworkTimeout,
        WebsocketNetworkError
    }
}
