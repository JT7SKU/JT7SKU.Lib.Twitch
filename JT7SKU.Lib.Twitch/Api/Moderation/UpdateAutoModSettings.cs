using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class UpdateAutoModSettings
    {
        // Updates the broadcaster’s AutoMod settings. The settings are used to automatically block inappropriate or harassing messages from appearing in the broadcaster’s chat room.
        // Requires a user access token that includes the moderator:manage:automod_settings scope.
        public string UpdateAutoModSettingsModeratorManageScope { get; set; } = "moderator:manage:automod_settings";
        public string ClientId { get; set; }
        public string PathUrl { get; set; }
        public UpdateAutoModSettingsRequestQuery RequestQuery { get; set; }
        public UpdateAutoModSettingsRequestBody RequestBody { get; set; }
        public UpdateAutoModSettingsResponseBody ResponseBody { get; set; }
        public UpdateAutoModSettingsResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateAutoModSettingsRequestQuery
    {
        [Required]
        public string BroadcasterID { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record UpdateAutoModSettingsRequestBody
    {
        public int OverallLevel { get; set; }
        public int Disability { get; set; }
        public int Aggression { get; set; }
        public int SexualitySexorGender { get; set; }
        public int Misogyny { get; set; }
        public int Bullying { get; set; }
        public int Swearing { get; set; }
        public int RaceEthnicityOrReligion { get; set; }
        public int SexBasedTherms { get; set; }
    }
    public record UpdateAutoModSettingsResponseBody
    {
        public UpdateAutoModSettingsData Data { get; set; }
    }
    public enum UpdateAutoModSettingsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record UpdateAutoModSettingsData
    {
        public string BroadcasterId { get; set; }
        public string ModeratorId { get; set; }
        public int OverallLevel { get; set; }
        public int Disability { get; set; }
        public int Aggression { get; set; }
        public int SexualitySexorGender { get; set; }
        public int Misogyny { get; set; }
        public int Bullying { get; set; }
        public int Swearing { get; set; }
        public int RaceEthnicityOrReligion { get; set; }
        public int SexBasedTherms { get; set; }
    }
}
