using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class GetChannelChatBadges
    {
        // Authorization Requires App Access Token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; }
        public GetChannelChatBadgesRequestQuery RequestQuery { get; set; }
        public GetChannelChatBadgesResponseBody ResponseBody { get; set; }
        public GetChannelChatBadgesResponseCodes ResponseCodes { get; set; }
    }
    public record GetChannelChatBadgesRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record GetChannelChatBadgesResponseBody
    {
        public GetChannelChatBadgesData Data { get; set; }
    }
    public enum GetChannelChatBadgesResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetChannelChatBadgesData
    {
        public string SetId { get; set; }

    }
}
