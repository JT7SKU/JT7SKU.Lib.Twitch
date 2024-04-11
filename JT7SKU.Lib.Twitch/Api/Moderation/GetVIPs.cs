using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class GetVIPs
    {
        // Requires a user access token that includes the channel:read:vips scope.
        // If your app also adds and removes VIP status, you can use the channel:manage:vips scope instead.
        public string GetVIPsChannelManageScope { get; set; } = "channel:manage:vips";
        public string GetVIPsChannelReadScope { get; set; } = "channel:read:vips";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channels/vips";
        public GetVIPsRequestQuery RequestQuery { get; set; }
        public GetVIPsResponseBody ResponseBody { get; set; }
        public GetVIPsResponseCodes ResponseCodes { get; set; }
    }
    public record GetVIPsRequestQuery
    {
        public string UserId { get; set; }
        [Required]
        public string BroadcasterId { get; set; }
        public int First {  get; set; }
        public string After { get; set; }
    }
    public record GetVIPsResponseBody
    {
        public GetVIPsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetVIPsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetVIPsData
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
    }
}
