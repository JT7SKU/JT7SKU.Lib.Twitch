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
    public class GetEmoteSets
    {
        // Authorization Requires App Access Token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/emotes/set";

    }
    public record GetEmoteSetsRequestQuery
    {
        [Required]
        public string EmoteSetId { get; set; } // For example, emote_set_id=1234&emote_set_id=5678. You may specify a maximum of 25 IDs. The response contains only the IDs that were found and ignores duplicate IDs.
    }
    public record GetEmoteSetsResponseBody
    {
       public GetGlobalEmotesData Data { get; set; }
        public string Template { get; set; }
    }
    public enum GetEmoteSetsResponseCodes
    {
        OK=200,
        BadRequest=400,
        Unauthirized=401
    }
    public record GetEmoteSetsData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Image Images { get; set; }
        public EmoteType EmoteType { get; set; }
        public string EmoteSetId { get; set; }
        public string OwnerId { get; set; }
        public EmoteFormat Format { get; set; }
        public EmoteScale Scale { get; set; }
        public ThemeMode ThemeMode { get; set; }
    }
}
