using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Teams
{
    public class GetChannelTeams
    {
        // Gets the list of Twitch teams that the broadcaster is a member of.
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/teams/channel";
        public GetChannelTeamsRequestQuery RequestQuery { get; set; }
        public GetChannelTeamsResponseBody ResponseBody { get; set; }
        public GetChannelTeamsResponseCodes ResponseCodes { get; set; }
    }
    public record GetChannelTeamsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record GetChannelTeamsResponseBody
    {
        public List<GetChannelTeamsRespData> Data { get; set; }
    }
    public enum GetChannelTeamsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
    public record GetChannelTeamsRespData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string Banner { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Info { get; set; }
        public string ThumbnailUrl { get; set; }
        public string TeamName { get; set; }
        public string TeamDisplayName { get; set; }
        public string Id { get; set; }
    }
}
