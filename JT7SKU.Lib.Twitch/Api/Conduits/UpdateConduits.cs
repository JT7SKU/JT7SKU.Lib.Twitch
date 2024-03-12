using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Conduits
{
    public class UpdateConduits
    {
        // Requires App Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/conduits";
        public UpdateConduitsRequestBody RequestBody { get; set; }
        public UpdateConduitsResponseBody ResponseBody { get; set; }
        public UpdateConduitsResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateConduitsRequestBody
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public int ShardCount { get; set; }
    }
    public record UpdateConduitsResponseBody
    {
        public UpdateConduitsData Data { get; set; }
    }
    public enum UpdateConduitsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthenticated = 401,
        NotFound = 404
    }
    public record UpdateConduitsData
    {
        public string Id { get; set; }
        public int ShardCount { get; set;}
    }
}
