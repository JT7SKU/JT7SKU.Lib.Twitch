using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class UpdateChatSettins
    {
        public string UpdateChatSettingsScope { get; set; } = "moderator:manage:chat_settings";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/settings";
        public UpdateChatSettingsRequestQuery RequestQuery { get; set; }
        public UpdateChatSettingsRequestBody RequestBody { get; set; }
        public UpdateChatSettingsResponseBody ResponseBody { get; set; }
        public UpdateChatSettingsResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateChatSettingsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required] public string ModeratorId { get; set; }
    }
    public record UpdateChatSettingsRequestBody
    {
        public bool EmoteMode { get; set; }
        public bool FollowerMode { get; set; }
        public int FollowerModeDuration { get; set; }
        public bool NonModeratorChatDelay { get; set; }
        public int NonModeratorChatDelayDuration { get; set ; }
        public bool SlowMode { get; set; }
        public int SlowModeWaiTime { get; set; }
        public bool SubsriberMode { get; set; }
        public bool UniqueChatmode { get; set; }
    }
    public record UpdateChatSettingsResponseBody
    {
        public UpdateChatSettingsData Data { get; set; }
    }
    public enum UpdateChatSettingsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record UpdateChatSettingsData
    {
        public string BroadcasterId { get; set; }
        public bool EmoteMode { get; set; }
        public bool FollowerMode { get; set; }
        public int FollowerModeDuration { get; set; }
        public bool NonModeratorChatDelay { get; set; }
        public int NonModeratorChatDelayDuration { get; set; }
        public bool SlowMode { get; set; }
        public int SlowModeWaiTime { get; set; }
        public bool SubsriberMode { get; set; }
        public bool UniqueChatmode { get; set; }
    }
}
