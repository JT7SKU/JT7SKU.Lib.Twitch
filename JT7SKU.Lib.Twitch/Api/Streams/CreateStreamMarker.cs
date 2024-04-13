using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Streams
{
    public class CreateStreamMarker
    {
        // Adds a marker to a live stream.
        // A marker is an arbitrary point in a live stream that the broadcaster or editor wants to mark,
        // so they can return to that spot later to create video highlights (see Video Producer,
        // Highlights in the Twitch UX).
        // You may not add markers:
        // If the stream is not live
        // If the stream has not enabled video on demand (VOD)
        // If the stream is a premiere (a live, first-viewing event that combines uploaded videos with live chat)
        // If the stream is a rerun of a past broadcast, including past premieres.
        // Requires a user access token that includes the channel:manage:broadcast scope.
        public string CreateStreamMarkerChannelManageScope { get; set; } = "channel:manage:broadcast";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/streams/markers";
        public CreateStreamMarkerRequestBody RequestBody { get; set; }
        public CreateStreamMarkerResponseBody ResponseBody { get; set; }
        public CreateStreamMarkerResponseCodes ResponseCodes { get; set; }
    }
    public record CreateStreamMarkerRequestBody
    {
        [Required]
        public string UserId { get; set; }
        public string Description { get; set; }
    }
    public record CreateStreamMarkerResponseBody
    {
        public List<CreateStreamMarkerRespData> Data { get; set; }
    }
    public enum CreateStreamMarkerResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404
    }
    public record CreateStreamMarkerRespData
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PositionSeconds { get; set; }
        public string Description { get; set; }
    }
}
