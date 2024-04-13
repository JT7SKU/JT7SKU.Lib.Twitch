using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Streams
{
    public class GetStreamMarkers
    {
        // Gets a list of markers from the user’s most recent stream or from the specified VOD/video.
        // A marker is an arbitrary point in a live stream that the broadcaster or editor marked,
        // so they can return to that spot later to create video highlights(see Video Producer, Highlights in the Twitch UX).
        // Requires a user access token that includes the user:read:broadcast or channel:manage:broadcast scope.
        public string GetStreamMarkersUserReadScope { get; set; } = "user:read:broadcast";
        public string GetStreamMarkersChannelManageScope { get; set; } = "channel:manage:broadcast";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/streams/markers";
        public GetStreamMarkersRequestQuery RequestQuery { get; set; }
        public GetStreamMarkersResponseBody ResponseBody { get; set; }
        public GetStreamMarkersResponseCodes ResponseCodes { get; set; }
    }
    public record GetStreamMarkersRequestQuery
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string VideoId { get; set; }
        public string First {  get; set; }
        public string Before { get; set; }
        public string After { get; set; }
    }
    public record GetStreamMarkersResponseBody
    {
        public GetStreamMarkersRespData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetStreamMarkersResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404
    }
    public record GetStreamMarkersRespData
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public List<StreamMarkerVideos> Videos { get; set; }
    }
}
