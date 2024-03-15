using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public  class CreateGuestStarSession
    {
        // BETA
        // Query parameter broadcaster_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:manage:guest_star
        public string CreateGuestStarSessionChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/session";
        public CreateGuestStarSessionRequestQuery RequestQuery { get; set; }
        public CreateGuestStarSessionResponseBody ResponseBody { get; set; }
        public CreateGuestStarSessionResponseCodes ResponseCodes { get; set; }
    }
    public record CreateGuestStarSessionRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record CreateGuestStarSessionResponseBody
    {
        public CreateGuestStarSessionData Data { get; set; }
    }
    public enum CreateGuestStarSessionResponseCodes
    {
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record CreateGuestStarSessionData
    {
        public string Id { get; set; }
        public List<Guest> Guests { get; set; }
    }
}
