using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    
    public class GetUserEmotes
    {
        // Beta feature
        public string GetUserEmotesScope { get; set; } = "user:read:emotes";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/emotes/user";
        public GetUserEmotesRequestQuery RequestQuery { get; set; }
        public GetUserEmotesResponseBody ResponseBody { get; set; }
        public GetUserEmotesResponseCodes ResponseCodes { get; set; }
    }
    public record GetUserEmotesRequestQuery
    {
        [Required]
        public string UserId { get; set; }
        public string BroadcasterId { get; set; }
        //public int First { get; set; }
        public string After { get; set; }
    }
    public record GetUserEmotesResponseBody
    {
        public GetUserEmotesData Data { get; set; }
        public string Template { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetUserEmotesResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetUserEmotesData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public EmoteType EmoteType { get; set; }
        public string EmoteSetId { get; set; }
        public string OwnerId { get; set; }
        public EmoteFormat Format { get; set; }
        public EmoteScale Scale { get; set; }
        public ThemeMode ThemeMode { get; set; }
    }
}
