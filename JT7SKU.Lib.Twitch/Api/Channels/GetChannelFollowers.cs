using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Channels
{
    public class GetChannelFollowers
    {
        public string ChannelFollowersScope { get; set; } = "moderator:read:followers";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channels/followers";
        public ChannelFollowersRequestQuery RequestQuery { get; set; }
        public ChannelFollowersResponseBody ResponseBody { get; set; }
        public ChannelFollowersResponseCodes MyProperty { get; set; }
    }
    public record ChannelFollowersRequestQuery
    {
        public string UserId { get; set; }
        [Required]
        public string BroadcasterId { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record ChannelFollowersResponseBody
    {
        public ChannelEditorsData Data { get; set; }
        public ChannelFollowersPagination Pagination { get; set; }
        public int Total { get; set; }
    }
    public enum ChannelFollowersResponseCodes
    {
        OK=200,
        BadRequest=400,
        UnAuthorized=401
    }
    public record ChannelFollowersData
    {
        public string FollowedAt { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
    }
    public record ChannelFollowersPagination
    {
        public string Cursor { get; set; }
    }
}
