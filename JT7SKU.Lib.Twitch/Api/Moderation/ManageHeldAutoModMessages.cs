using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class ManageHeldAutoModMessages
    {
        // Allow or deny the message that AutoMod flagged for review. For information about AutoMod, see How to Use AutoMod.
        // To get messages that AutoMod is holding for review, subscribe to the automod-queue.<moderator_id>.<channel_id> topic using PubSub. PubSub sends a notification to your app when AutoMod holds a message for review.
        // Requires a user access token that includes the moderator:manage:automod scope.
        public string ManageHeldAutoModMessagesModeratorManageScope { get; set; } = "moderator:manage:automod";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/automod/message";
        public ManageHeldAutoModMessagesRequestBody RequestBody { get; set; }
        public ManageHeldAutoModMessagesResponseCodes ResponseCodes { get; set; }
    }
    public record ManageHeldAutoModMessagesRequestBody
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string MsgId { get; set; }
        [Required]
        public string Action {  get; set; } // ALLOW or DENY
    }
    public enum ManageHeldAutoModMessagesResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404
    }
}
