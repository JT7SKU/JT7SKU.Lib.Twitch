using JT7SKU.Lib.Twitch.EventSub.Subscriptions.Automod.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.WebSocket_Messages
{
    internal class CloseMessage
    {
       // standard websocked close frame

    }
    public enum CloseMessageCodes
    {
        InternalServerError = 4000,
        Clientsentinboundtraffic = 4001,
        ClientFailedPingPong = 4002,
        ConnectionUnused = 4003,
        ReconnectGraceTimeExpired = 4004,
        NetworkTimeOut = 4005,
        NetworkError = 4006,
        InvalidReconnect =4007
    }
}
