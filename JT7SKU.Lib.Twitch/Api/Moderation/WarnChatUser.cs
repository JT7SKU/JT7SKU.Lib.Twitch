using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.Api.Moderation
{
    internal class WarnChatUser
    {
        ///<summary>
        /// Warns a user in the specified broadcaster’s chat room, preventing them from chat interaction until the warning is acknowledged. 
        /// New warnings can be issued to a user when they already have a warning in the channel (new warning will replace old warning).
        /// Authorization 
        /// Requires a user access token that includes the <para>moderator:manage:warnings</para> scope. 
        /// Query parameter moderator_id must match the user_id in the user access token.
        ///</summary>
        public string WarnChatUserModeratorScope { get; set; } = "moderator:manage:warnings";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/warnings";
        public WarnChatUserRequestQuery RequestQuery { get; set; }
        public WarnChatUserRequestBody RequestBody { get; set; }
        public WarnChatUserResponseBody ResponseBody { get; set; }
        public WarnChatUserResponseCodes ResponseCodes { get; set; }

    }
    public record WarnChatUserRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set;}
        [Required]
        public string ModeratorId { get; set;}
    }
    public record WarnChatUserRequestBody
    {
        [Required]
        public WarnChatUserRequestData Data { get; set; }
    }
    public record WarnChatUserResponseBody
    {
        public List<WarnChatUserResponseData> Data { get; set; }
    }
    public record WarnChatUserRequestData
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Reason { get; set; }
    }
    public record WarnChatUserResponseData
    {
        public string BroadcasterId { get; set; }
        public string UsedId { get; set; }
        public string ModeratorId { get; set;}
        public string Reason { get; set; }
    }
    public enum WarnChatUserResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        Conflict = 409,
        TooManyRequest = 429,
        InternalServerError = 500
    }
}
