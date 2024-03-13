using JT7SKU.Lib.Twitch.Api.Bits;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class UpdateExtensionBitProduct
    {
        // Requires an app access token. The client ID in the app access token must match the extension’s client ID.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/bits/extensions";
        public UpdateExtensionBitProductRequestBody RequestBody { get; set; }
        public UpdateExtensionBitProductResponseBody ResponseBody { get; set; }
        public UpdateExtensionBitProductResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateExtensionBitProductRequestBody
    {
        [Required]
        public string Sku {  get; set; }
        [Required]
        public ProductCost Cost { get; set; }
        [Required]
        public string DisplayName { get; set; }
        public bool IsDevelopment { get; set; }
        public DateTime Expiration {  get; set; }
        public bool IsBroadcast {  get; set; }
    }
    public record UpdateExtensionBitProductResponseBody
    {
        public UpdateExtensionBitProductData Data { get; set; }
    }
    public enum UpdateExtensionBitProductResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record UpdateExtensionBitProductData
    {
        public string Sku {get; set;}
        public ProductCost Cost {get; set;}
        public bool IsDevelopment {get; set;}
        public DateTime Expiration {get; set;}
        public bool IsBroadcast {get; set;}
    }
}

