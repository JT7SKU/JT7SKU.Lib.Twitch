using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Conduits
{
    public class GetConduitShards
    {
        // Requires App Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/conduits/shards";
        public GetConduitShardsRequestQuery RequestQuery { get; set; }
        public GetConduitShardsResponseBody ResponseBody { get; set; }
        public GetConduitShardsResponseCodes ResponseCodes { get; set; }
    }
    public record GetConduitShardsRequestQuery
    {
        [Required]
        public string ConduitId { get; set; }
        public string Status { get; set; }
        public string After { get; set; }
    }
    public record GetConduitShardsResponseBody
    {
        public GetConduitShardsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetConduitShardsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthenticated = 401,
        NotFound = 404
    }
    public record GetConduitShardsData
    {
        public string Id { get; set; }
        public ConduitStatus Status { get; set;}
        public Transport Transport { get; set; }
    }
}
