using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class DeleteChatMessages
    {
        // Requires a user access token that includes the moderator:manage:chat_messages scope.
        public string DeleteChatMessagesModeratorManageScope { get; set; } = "moderator:manage:chat_messages";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/chat";
        public DeleteChatMessagesRequestQuery RequestQuery { get; set; }
        public DeleteChatMessagesResponseCodes ResponseCodes { get; set; }
    }
    public record DeleteChatMessagesRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        public string MessageId { get; set; }
    }
    public enum DeleteChatMessagesResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404
    }
}
