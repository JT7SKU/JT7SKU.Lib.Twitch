using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Conduits
{
    public class GetConduits
    {
        // requires App Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/conduits";
        public GetConduitsResponseBody ResponseBody { get; set; }
        public GetConduitsResponseCodes ResponseCodes { get; set; }
    }
    public record GetConduitsResponseBody
    {
        public GetConduitsData Data { get; set; }
    }
    public enum GetConduitsResponseCodes
    {
        OK = 200,
        Unauthenticated = 401
    }
    public record GetConduitsData
    {
        public string Id { get; set; }
        public int ShardCount { get; set; }
    }
}
