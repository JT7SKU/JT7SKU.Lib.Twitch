using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Raids
{
    internal class StartARaid
    {
        // Raid another channel by sending the broadcaster’s viewers to the targeted channel.
        // When you call the API from a chat bot or extension,
        // the Twitch UX pops up a window at the top of the chat room that identifies the number of viewers in the raid.
        // The raid occurs when the broadcaster clicks Raid Now or after the 90-second countdown expires.
        // To determine whether the raid successfully occurred, you must subscribe to the Channel Raid event.
        // For more information, see Get notified when a raid begins.
        // To cancel a pending raid, use the Cancel a raid endpoint.
        // Rate Limit: The limit is 10 requests within a 10-minute window.
        // Requires a user access token that includes the channel:manage:raids scope.
        public string SatrtARaidChannelManageScope { get; set; } = "channel:manage:raids";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/raids";
        public StartARaidRequestQuery RequestQuery { get; set; }
        public StartARaidResponseBody ResponseBody { get; set; }
        public StartARaidResponseCodes ResponseCodes { get; set; }
    }
    public record StartARaidRequestQuery
    {
        [Required]
        public string FromBroadcasterId { get; set; }
        [Required]
        public string ToBroadcasterId { get; set; }
    }
    public record StartARaidResponseBody
    {
        public StartARaidRespData Data { get; set; }
    }
    public enum StartARaidResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404,
        Conflict = 409,
        TooManyRequests = 429
    }
    public record StartARaidRespData
    {
        public DateTime CreatedAt { get; set; }
        public bool IsMature { get; set; }
    }
}
