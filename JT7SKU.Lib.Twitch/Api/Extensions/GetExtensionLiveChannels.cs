using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class GetExtensionLiveChannels
    {
        // Requires App Access Token or User Accesstoken
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/live";
        public GetExtensionLiveChannelsRequestQuery RequestQuery { get; set; }
        public GetExtensionLiveChannelsResponseBody ResponseBody { get; set; }
        public GetExtensionLiveChannelsResponseCodes ResponseCodes { get; set; }
    }
    public record GetExtensionLiveChannelsRequestQuery
    {
        [Required]
        public string ExtensionId { get; set; }
        public int First {  get; set; }
        public string After { get; set; }
    }
    public record GetExtensionLiveChannelsResponseBody
    {
        public GetExtensionLiveChannelsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetExtensionLiveChannelsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
    public record GetExtensionLiveChannelsData
    {
        public string BroacasterId { get; set; }
        public string BroacasterName { get; set; }
        public string GameName { get; set; }
        public string GameId { get; set; }
        public string Title { get; set; }
    }
}
