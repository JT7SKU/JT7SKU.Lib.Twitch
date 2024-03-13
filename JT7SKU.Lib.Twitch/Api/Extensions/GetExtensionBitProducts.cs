using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class GetExtensionBitProducts
    {
        // Requires an app access token. The client ID in the app access token must be the extension’s client ID.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/bits/extensions";
        public GetExtensionBitProductsRequestQuery RequestQuery { get; set; }
        public GetExtensionBitProductsResponseBody ResponseBody { get; set; }
        public GetExtensionBitProductsResponseCodes ResponseCodes { get; set; }
    }
    public record GetExtensionBitProductsRequestQuery
    {
        public bool ShouldIncludeAll {  get; set; }
    }
    public record GetExtensionBitProductsResponseBody
    {
        public GetExtensionBitProductsData Data { get; set; }
    }
    public enum GetExtensionBitProductsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetExtensionBitProductsData
    {
        public string Sku { get; set; }
        public ProductCost Cost { get; set; }
        public bool IsDevelopment { get; set; }
        public string DisplayName { get; set; }
        public DateTime Expiration {  get; set; }
        public bool IsBroadcast { get; set; }
    }
}
