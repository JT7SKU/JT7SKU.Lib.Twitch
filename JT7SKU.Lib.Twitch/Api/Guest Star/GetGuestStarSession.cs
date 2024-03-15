using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class GetGuestStarSession
    {
        // BETA
        // Requires OAuth Scope: channel:read:guest_star, channel:manage:guest_star, moderator:read:guest_star or moderator:manage:guest_star
        // Guests must be either invited or assigned a slot within the session
        public string GetGuestStarSessionChannelReadScope { get; set; } = "channel:read:guest_star";
        public string GetGuestStarSessionChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string GetGuestStarSessionModeratorReadScope { get; set; } = " moderator:read:guest_star";
        public string GetGuestStarSessionModeratorManageScope { get; set; } = "moderator:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/session";
        public GetChannelGuestStarSessionRequestQuery RequestQuery { get; set; }
        public GetChannelGuestStarSessionResponseBody ResponseBody { get; set; }
        public GetChannelGuestStarSessionResponseCodes ResponseCodes { get; set; }
    }
    public record GetChannelGuestStarSessionRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record GetChannelGuestStarSessionResponseBody
    {
        public GetChannelGuestStarSessionData Data { get; set; }
    }
    public enum GetChannelGuestStarSessionResponseCodes
    {
        BadRequest = 400,
        Unauthenticated = 401
    }
    public record GetChannelGuestStarSessionData
    {
        public string Id { get; set; }
        public List<Guest> Guests { get; set; }
    }
}
