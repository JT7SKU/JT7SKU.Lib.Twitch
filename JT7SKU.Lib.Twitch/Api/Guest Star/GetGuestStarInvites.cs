using JT7SKU.Lib.Twitch.Api.Chat;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class GetGuestStarInvites
    {
        // BETA 
        // Query parameter broadcaster_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:read:guest_star, channel:manage:guest_star, moderator:read:guest_star or moderator:manage:guest_star
        public string GetGuestStarInvitesChannelReadScope { get; set; } = "channel:read:guest_star";
        public string GetGuestStarInvitesChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string GetGuestStarInvitesModeratorReadScope { get; set; } = "moderator:read:guest_star";
        public string GetGuestStarInvitesModeratorManageScope { get; set; } = "moderator:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/invites";
        public GetGuestStarInvitesRequestQuery RequestQuery { get; set; }
        public GetGuestStarInvitesResponseBody ResponseBody { get; set; }
        public GetGuestStarInvitesResponseCodes ResponseCodes { get; set; }
    }
    public record GetGuestStarInvitesRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        [Required]
        public string SessionId { get; set; }
    }
    public record GetGuestStarInvitesResponseBody
    {
        public List<UserInvite> Data { get; set; }
    }
    public enum GetGuestStarInvitesResponseCodes
    {
        BadRequest = 400
    }
}
