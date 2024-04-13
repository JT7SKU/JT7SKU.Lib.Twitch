
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace JT7SKU.Lib.Twitch.Api.Videos
{
    public class DeleteVideos
    {
        // Deletes one or more videos. You may delete past broadcasts, highlights, or uploads.
        // Requires a user access token that includes the channel:manage:videos scope.
        public string DeleteVdeosChannelManageScope { get; set; }
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/videos";
        public DeleteVideosRequestQuery RequestQuery { get; set; }
        public DeleteVideosResponseBody ResponseBody { get; set; }
        public DeleteVideosResponseCodes ResponseCodes { get; set; }
    }
    public record DeleteVideosRequestQuery
    {
        [Required]
        public string Id { get; set; }
    }
    public record DeleteVideosResponseBody
    {
        public string[] Data { get; set; }
    }
    public enum DeleteVideosResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
}
