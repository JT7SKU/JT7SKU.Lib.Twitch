using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Clips
{
    public class CreateClip
    {
        public string CreateClipEditScope { get; set; } = "clips:edit";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/clips";
        public CreateClipRequestQuery RequestQuery { get; set; }
        public CreateClipResponseBody ResponseBody { get; set; }
        public CreateClipResponseCodes ResponseCodes { get; set; }
    }
    public record CreateClipRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public bool HasDelay { get; set; }
    }
    public record CreateClipResponseBody
    {
        public string EditUrl { get; set; }
        public string Id { get; set; }
    }
    public enum CreateClipResponseCodes
    {
        Accepted = 202,
        BadRequest= 400,
        Unauthorized=401,
        Forbidden = 403,
        NotFound = 404
    }
}
