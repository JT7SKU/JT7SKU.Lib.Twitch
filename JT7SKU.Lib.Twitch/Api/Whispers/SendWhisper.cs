using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Whispers
{
    public class SendWhisper
    {
        // Sends a whisper message to the specified user.
        // NOTE: The user sending the whisper must have a verified phone number (see the Phone Number setting in your Security and Privacy settings).
        // NOTE: The API may silently drop whispers that it suspects of violating Twitch policies.
        // (The API does not indicate that it dropped the whisper; it returns a 204 status code as if it succeeded.)
        // Rate Limits: You may whisper to a maximum of 40 unique recipients per day.
        // Within the per day limit, you may whisper a maximum of 3 whispers per second and a maximum of 100 whispers per minute.
        // Requires a user access token that includes the user:manage:whispers scope.
        public string SendWhisperUserManageScope { get; set; } = "user:manage:whispers";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/whispers";
        public SendWhisperRequestQuery RequestQuery { get; set; }
        public SendWhisperRequestBody RequestBody { get; set; }
        public SendWhisperResponseCodes ResponseCodes { get; set; }
    }
    public record SendWhisperRequestQuery
    {
        [Required]
        public string FromUserId { get; set; }
        [Required]
        public string ToUserId { get; set; }
    }
    public record SendWhisperRequestBody
    {
        [MaxLength(10000)]
        public string Message { get; set; }
    }
    public enum SendWhisperResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        TooManyRequests = 429
    }
}
