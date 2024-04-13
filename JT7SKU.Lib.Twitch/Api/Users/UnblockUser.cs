using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Users
{
    public class UnblockUser
    {
        // Removes the user from the broadcaster’s list of blocked users. The user ID in the OAuth token identifies the broadcaster who’s removing the block.
        // Requires a user access token that includes the user:manage:blocked_users scope.
        public string UnblockUserUserManageScope { get; set; } = "user:manage:blocked_users";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/users/blocks";
        public UnblockUserRequestQuery RequestQuery { get; set; }
        public UnblockUserResponseCodes ResponseCodes { get; set; }
    }
    public record UnblockUserRequestQuery
    {
        [Required]
        public string TargetUserId { get; set; }
    }
    public enum UnblockUserResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401
    }
}
