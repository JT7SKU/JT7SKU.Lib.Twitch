using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Streams
{
    public class GetStreamKey
    {
        // Gets the channel’s stream key.
        // Requires a user access token that includes the channel:read:stream_key scope.
        public string GetStreamKeyChannelReadScope { get; set; } = "channel:read:stream_key";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/streams/key";
        public GetStreamKeyRequestQuery RequestQuery { get; set; }
        public GetStreamKeyResponseBody ResponseBody { get; set; }
        public GetStreamKeyResponseCodes ResponseCodes { get; set; }
    }
    public record GetStreamKeyRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record GetStreamKeyResponseBody
    {
        public List<GetStreamKeyRespData> Data { get; set; }
    }
    public enum GetStreamKeyResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetStreamKeyRespData
    {
        public string StreamKey { get; set; }
    }
}
