using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Entitlements
{
    public class UpdateDropsEntitlements
    {
        
        // Requires App access token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/entitlements/drops";
        public UpdateDropsEntitlementsRequestBody RequestBody { get; set; }
        public UpdateDropsEntitlementsResponseBody ResponseBody { get; set; }
        public UpdateDropsEntitlementsResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateDropsEntitlementsRequestBody
    {
        public List<string> EntitlementIds { get; set; }
        public FullfillmentStatus FullfillmentStatus { get; set; }
    }
    public record UpdateDropsEntitlementsResponseBody
    {
        public UpdateDropsEntitlementsData Data { get; set; }
    }
    public enum UpdateDropsEntitlementsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        InternalServerError = 500
    }
    public record UpdateDropsEntitlementsData
    {
      public EntitlementStatus Status { get; set; }
        public List<string> Ids { get; set; }
    }
}
