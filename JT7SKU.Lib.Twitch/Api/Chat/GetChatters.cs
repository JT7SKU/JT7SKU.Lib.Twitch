using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class GetChatters
    {
        public string GetChattersScope { get; set; } = "moderator:read:chatters";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/chatters";
    }
    public record GetChattersRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record GetChattersResponseBody
    {
        public GetChattersData Data { get; set; }
        public Pagination Pagination { get; set; }
        public int Total { get; set; }
    }
    public enum GetChattersResponseCodes
    {
        OK=200,
        BadRequest=400,
        Unauthorized=401,
        Forbidden=403
    }
    public record GetChattersData
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
    }
}
