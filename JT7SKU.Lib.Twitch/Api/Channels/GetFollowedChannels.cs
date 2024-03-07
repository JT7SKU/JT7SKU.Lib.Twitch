using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Channels
{
    public class GetFollowedChannels
    {
        public string FollowedChannelsScope { get; set; } = "user:read:follows";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channels/followed";
        public FollowedChannelsRequestQuery FollowedChannelsRequestQuery { get; set; }
        public FollowedChannelsResponseBody followedChannelsResponseBody { get; set; }
        public FollowedChannelsResponseCodes ResponseCodes { get; set; }
    }
    public record FollowedChannelsRequestQuery
    {
        [Required]
        public string UserId { get; set; }
        public string BroadcasterId { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record FollowedChannelsResponseBody
    {
        public FollowedChannelsData Data { get; set; }
        public FollowedChannelsPagination Pagination { get; set; }
        public int Total { get; set; }

    }
    public record FollowedChannelsData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string FollowedAt { get; set; }
    }
    public record FollowedChannelsPagination
    {
        public string Cursor { get; set; }
    }
    public enum FollowedChannelsResponseCodes
    {
        OK= 200,
        BadRequest=400,
        Unauthorized=401
    }
}
