using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Tags
{
    public class GetStreamTags
    {
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string Pathurl { get; set; } = "/streams/tags";
        public GetStreamTagsRequestQuery RequestQuery { get; set; }
        public GetStreamTagsResponseBody ResponseBody { get; set; }
        public GetStreamTagsResponseCodes ResponseCodes { get; set; }
    }
    public record GetStreamTagsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record GetStreamTagsResponseBody
    {
        public List<GetStreamTagsData> Data { get; set; }
    }
    public enum GetStreamTagsResponseCodes
    {
        OK  =200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetStreamTagsData
    {
        public string TagId { get; set; }
        public bool IsAuto { get; set; }
        public Dictionary<string, string> LocalizationNames { get; set; }
        public Dictionary<string, string> LocalizationDescription { get; set; }
    }
}
