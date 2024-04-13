using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Users
{
    public class BlockUser
    {
        // Blocks the specified user from interacting with or having contact with the broadcaster.
        // The user ID in the OAuth token identifies the broadcaster who is blocking the user. 
        // Requires a user access token that includes the user:manage:blocked_users scope.
        public string BlockUserUserManageScope { get; set; } = "user:manage:blocked_users";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/users/blocks";
        public BlockUserRequestQuery RequestQuery { get; set; }
        public BlockUserResponseCodes ResponseCodes { get; set; }
    }
    public record BlockUserRequestQuery
    {
        [Required]
        public string TargetUserId { get; set; }
        public SourceContext SourceContext {  get; set; }
        public BlockReason Reason { get; set; }
    }
    
    public enum BlockUserResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    
}
