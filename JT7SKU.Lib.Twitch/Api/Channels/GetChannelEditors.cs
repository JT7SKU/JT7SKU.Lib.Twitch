using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Channels
{
    public class GetChannelEditors
    {
        public string ChannelEditorsScope { get; set; } = "channel:read:editors";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channels/editors";
        public ChannelEditorsRequestQuery ChannelEditorsRequestQuery { get; set; }
        public ChannelEditorsResponseBody ChannelEditorsResponseBody { get; set; }
        public enum ChannelEditorsResponseCodes { OK=200,BadRequest=400, Unauthorized=401 }
    }
    public record ChannelEditorsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record ChannelEditorsResponseBody
    {
        public ChannelEditorsData Data { get; set; }
    }
    public record ChannelEditorsData
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string CreatedAt { get; set; }
    }
}
