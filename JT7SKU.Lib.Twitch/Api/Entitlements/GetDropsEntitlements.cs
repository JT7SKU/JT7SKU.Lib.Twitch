using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Entitlements
{
    public class GetDropsEntitlements
    {
        public enum EntitlementAppTokenParameters { None = 0, UserId = 1, UserId_GameId = 2, GameId = 3 }
        public enum EntitlementUserTokenParameters { None = 0, UserId = 1, UserId_GameId = 2, Gameid = 3 }
        // Requires App access token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/entitlements/drops";
        public GetDropsEntitlementsRequestQuery RequestQuery { get; set; }
        public GetDropsEntitlementsResponseBody ResponseBody { get; set; }
        public GetDropsEntitlementsResponseCodes ResponseCodes { get; set; }
    }
    public record GetDropsEntitlementsRequestQuery
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string GameId { get; set; }
        public string FullfillmentStatus { get; set; }
        public string After { get; set; }
        public int First { get; set; }
    }
    public record GetDropsEntitlementsResponseBody
    {
        public GetDropsEntitlementsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public record GetDropsEntitlementsData
    {
        public string Id { set; get; }
        public string BenefictId { get; set; }
        public string Timestampt { get; set; }
        public string UserId { get; set; }
        public string GameId { get; set; }
        public string FullfillmentStatus { get; set; }
        public string LastUpdated { get; set; }
    }
    public enum GetDropsEntitlementsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        InternalServerError = 500
    }
}
