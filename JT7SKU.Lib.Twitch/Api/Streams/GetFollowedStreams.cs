using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Streams
{
    public class GetFollowedStreams
    {
        // Gets the list of broadcasters that the user follows and that are streaming live.
        // Requires a user access token that includes the user:read:follows scope.
        public string GetFollowedStreamsUserReadScope { get; set; } = "user:read:follows";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/streams/followed";
        public GetFollowedStreamsRequestQuery RequestQuery { get; set; }
        public GetFollowedStreamsResponseBody ResponseBody { get; set; }
        public GetFollowedStreamsResponseCodes ResponseCodes { get; set; }
    }
    public record GetFollowedStreamsRequestQuery
    {
        [Required]
        public string UserId { get; set; }
        public int First {  get; set; }
        public string After { get; set; }
    }
    public record GetFollowedStreamsResponseBody
    {
        public List<GetFollowedStreamsRespData> Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetFollowedStreamsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetFollowedStreamsRespData
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string GameId { get; set; }
        public string GameName { get; set; }
        public StreamType Type { get; set; }
        public string Title { get; set; }
        public int ViewerCount { get; set; }
        public DateTime StartedAt { get; set; }
        public string Language {  get; set; }
        public string ThumbnailUrl { get; set; }
        public string[] TagsIds { get; set; }
        public string[] Tags { get; set; }
        public bool IsMature { get; set; }
    }
}
