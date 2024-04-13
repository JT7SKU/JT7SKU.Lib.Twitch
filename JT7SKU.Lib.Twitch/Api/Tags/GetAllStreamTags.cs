using JT7SKU.Lib.Twitch.Models;
using Orleans.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Tags
{
    public class GetAllStreamTags
    {
        // supposed to not be used right now as return empy array by Twitch since IMPORTANT As of February 28, 2023, this endpoint returns an empty array. On July 13, 2023
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/tags/streams";
        public GetAllStreamTagsRequestQuery RequestQuery { get; set; }
        public GetAllStreamTagsResponseBody ResponseBody { get; set; }
        public GetAllStreamTagsResponseCodes ResponseCodes { get; set; }
    }
    public record GetAllStreamTagsRequestQuery
    {
        public string TagId { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record GetAllStreamTagsResponseBody
    {
        public List<GetAllStreamTagsRespData> Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetAllStreamTagsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetAllStreamTagsRespData
    {
        public string TagId { get; set; }
        public bool IsAuto { get; set; }
        public Dictionary<string, string> LocalizationNames { get; set; }
        public Dictionary<string, string> LocalizationDescription { get; set; }
    }
}
