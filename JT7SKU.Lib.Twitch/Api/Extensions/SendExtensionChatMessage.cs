using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class SendExtensionChatMessage
    {
        // Requires JWT created by Extension Backed Service JWT must include Role, UserId and Exp see JWT Schema the 'role' must be external
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/chat";
        public SendExtensionChatMessageRequestQuery RequestQuery { get; set; }
        public SendExtensionChatMessageRequestBody RequestBody { get; set; }
        public SendExtensionChatMessageResponseCodes ResponseCodes { get; set; }
    }
    public record SendExtensionChatMessageRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record SendExtensionChatMessageRequestBody
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public string ExtensionId { get; set; }
        [Required]
        public string ExtensionVersion { get; set; }
    }
    public enum SendExtensionChatMessageResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401
    }
}
