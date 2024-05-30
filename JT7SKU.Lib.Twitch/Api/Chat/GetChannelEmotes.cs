using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Emojis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class GetChannelEmotes
    {
       //need user access token or app access token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/emotes";
        public GetChannelEmotesRequestQuery RequestQuery { get; set; }
        public GetChannelEmotesResponseBody ResponseBody { get; set; }
        public GetChannelEmotesResponseCodes ResponseCodes { get; set; }
    }
    public record GetChannelEmotesRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record GetChannelEmotesResponseBody
    {
        public GetChannelEmotesData Data { get; set; }
        public string Template { get; set; } //templateURL CDN to look more
    }
    public enum GetChannelEmotesResponseCodes
    {
        OK=200,
        BadRequest=400,
        Unauthorized=401
    }
    public record GetChannelEmotesData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Image Images { get; set; }
        public SubPlanType Tier { get; set; }
        public EmoteType EmoteType { get; set; }
        public string EmoteSetId { get; set; }
        public EmoteFormat Format { get; set; }
        public EmoteScale Scale { get; set; }
        public ThemeMode ThemeMode { get; set; }
    }
}
