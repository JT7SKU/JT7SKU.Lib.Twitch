using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Conduits
{
    public class CreateConduit
    {
        // Requires App Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/conduits";
        public CreateConduitRequestBody RequestBody { get; set; }
        public CreateConduitResponseBody ResponseBody { get; set; }
        public CreateConduitResponseCodes RespnseCodes { get; set; }
    }
    public record CreateConduitRequestBody
    {
        [Required]
        public int ShardCount { get; set; }
    }
    public record CreateConduitResponseBody
    {
        public CreateConduitData Data { get; set; }
    }
    public enum CreateConduitResponseCodes
    {
        OK =200,
        BadRequest = 400,
        Unauthenticated = 401,
        TooManyRequests = 426
    }
    public record CreateConduitData
    {
        public string Id { get; set; }
        public int ShardCount { set; get; }
    }
}
