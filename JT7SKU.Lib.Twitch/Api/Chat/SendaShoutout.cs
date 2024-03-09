using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class SendAShoutout
    {
        // Rate Limits once every 2 minutes and Same broadcaster every 60minutes
        public string SendAShoutoutScope { get; set; } = "moderator:manage:shoutouts";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/shoutouts";
        public SendAShoutoutRequestQuery RequestQuery { get; set; }
        public SendAShoutoutResponseCodes ResponseCodes { get; set; }
    }
    public record SendAShoutoutRequestQuery
    {
        [Required]
        public string FromBroadcasterId { get; set; }
        [Required]
        public string ToBroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public enum SendAShoutoutResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        TooManyRequests = 429
    }
}
