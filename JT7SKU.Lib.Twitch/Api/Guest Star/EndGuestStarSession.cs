using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class EndGuestStarSession
    {
        // BETA
        // Query parameter broadcaster_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:manage:guest_star
        public string EndGuestStarSesssionChannelMangeScope { get; set; } = "channel:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/session";
        public EndGuestStarSessionRequestQuery RequestQuery { get; set; }
        public EndGuestStarSessionResponseBody ResponseBody { get; set; }
        public EndGuestStarSessionResponseCodes ResponseCodes { get; set; }
    }
    public record EndGuestStarSessionRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string SessionId { get; set; }
    }
    public record EndGuestStarSessionResponseBody
    {
        public EndGuestStarSessionData Data { get; set; }
    }
    public enum EndGuestStarSessionResponseCodes
    {
        BadRequest = 400,
        Forbidden = 403
    }
    public record EndGuestStarSessionData
    {
        public string Id { get; set; }
        public List<Guest> Guests { get; set; }
    }
}
