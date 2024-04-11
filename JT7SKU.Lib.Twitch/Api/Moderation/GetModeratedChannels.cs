using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class GetModeratedChannels
    {
        // Query parameter user_id must match the user ID in the User-Access token
        // Requires OAuth Scope: user:read:moderated_channels
        public string GetModeratedChannelsUserReadScope { get; set; } = "user:read:moderated_channels";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/channels";
        public GetModeratedChannelsRequestQuery RequestQuery { get; set; }
        public GetModeratedChannelsResponseBody ResponseBody { get; set; }
    }
    public record GetModeratedChannelsRequestQuery
    {
        [Required]
        public string UserId { get; set; }
        public string After {  get; set; }
        public int First {  get; set; }
    }
    public record GetModeratedChannelsResponseBody
    {
        public GetModeratedChannelsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public record GetModeratedChannelsData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
    }
    
}
