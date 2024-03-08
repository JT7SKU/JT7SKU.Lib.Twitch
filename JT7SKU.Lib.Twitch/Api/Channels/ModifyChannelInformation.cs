using JT7SKU.Lib.Twitch.Api.CCLs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Channels
{
    public class ModifyChannelInformation
    {
        public string ModifyChannelInformationScope { get; set; } ="channel:manage:broadcast";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channels";
        public ModifyChannelInformationRequestQuery ModifyChannelInformationRequestQuery { get; set; }
        public ModifyChannelInformationRequestBody ModifyChannelInformationResponseBody { get; set; }
        public enum ModifyChannelsResponseCodes { No_Content= 204, BadRequest=400, Unauthorized = 401, Forbidden = 403, TooManyRequest=409,InternalServerError=500}
    }
    public record ModifyChannelInformationRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record ModifyChannelInformationRequestBody
    {
        public string GameId { get; set; }
        public string BroadcasterLanguage { get; set; }
        public string Title { get; set; }
        public int Delay { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<Labels> ConcontentClassificationLabels { get; set; }
        public bool Is_Branded_Content { get; set; }
    }
    public record Labels
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public bool IsEnabled { get; set; }
    }
    

}
