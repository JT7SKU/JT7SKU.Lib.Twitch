using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Conduit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace JT7SKU.Lib.Twitch.Api.Conduits
{
    public class UpdateConduitShards
    {
        // Requires App Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/conduits/shards";
        public UpdateConduitRequestBody RequestBody { get; set; }
        public UpdateConduitResponseBody ResponseBody { get; set; }
        public UpdateConduitShardsResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateConduitRequestBody
    {
        [Required]
        public string ConduitId { get; set; }
        [Required]
        public List<ConduitShard> Shards { get; set; }
    }
    public record UpdateConduitResponseBody
    {
        public UpdateConduitData Data { get; set; }
        public UpdateConduitErrors Errors { get; set; }
    }
    public enum UpdateConduitResponseCodes
    {
        Accepted = 202,
        BadRequest = 400,
        Unauthenticated = 401,
        NotFound = 404
    }
    public record UpdateConduitData
    {
        public string Id { get; set; }
        public ConduitStatus Status { get; set; }
        public Transport Transport { get; set; }
    }
    public record UpdateConduitErrors
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }
    }
}
