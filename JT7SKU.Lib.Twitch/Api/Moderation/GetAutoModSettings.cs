using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class GetAutoModSettings
    {
        // Gets the broadcaster’s AutoMod settings. The settings are used to automatically block inappropriate or harassing messages from appearing in the broadcaster’s chat room.
        // Requires a user access token that includes the moderator:read:automod_settings scope.
        public string GetAutoModSettingsModeratorReadScope { get; set; } = "moderator:read:automod_settings";
        public string ClientId { get; set; }
        public string Pathurl { get; set; } = "/moderation/automod/settings";
        public GetAutoModSettingsRequestQuery RequestQuery { get; set; }
        public GetAutoModSettingsResponseBody ResponseBody { get; set; }
        public GetAutoModSettingsResponseCodes ResponseCodes { get; set; }
    }
    public record GetAutoModSettingsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record GetAutoModSettingsResponseBody
    {
        public GetAutoModSettingsData Data { get; set; }
    }
    public enum GetAutoModSettingsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record GetAutoModSettingsData
    {
        public string BroadcasterId { get; set; }
        public string ModeratorId { get; set; }
        public int OverallLevel { get; set; }
        public int Disability { get; set; }
        public int Aggression { get; set; }
        public int SexualitySexorGender { get; set; }
        public int Misogyny {  get; set; }
        public int Bullying { get; set; }
        public int Swearing { get; set; }
        public int RaceEthnicityOrReligion { get; set; }
        public int SexBasedTherms { get; set; }
    }
}
