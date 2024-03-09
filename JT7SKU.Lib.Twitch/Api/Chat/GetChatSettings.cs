using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class GetChatSettings
    {
        // Authorization Requires App Access Token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/settings";
        public GetChatSettingsRequestQuery RequestQuery { get; set; }
        public GetChatSettingsResponseBody ResponseBody { get; set; }
        public GetChatSettingsResponseCodes ResponseCodes { get; set; }
    }
    public record GetChatSettingsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public string ModeatorId { get; set; }
    }
    public record GetChatSettingsResponseBody
    {
        public GetChatSettingsData Data { get; set; }
    }
    public enum GetChatSettingsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetChatSettingsData
    {
        public string Broadcasterid { get; set; }
        public bool EmoteMode { get; set; }
        public bool FollowMode { get; set; }
        public int FollowModeDuration { get; set; }
        public string ModeratorId { get; set; }
        public bool NonModeratorChatDelay { get; set; }
        public int NonModeratorChatDelayDuration { get; set; }
        public bool SlowMode { get; set; }
        public int SlowModeWaitTime { get; set; }
        public bool SubscriptionMode { get; set; }
        public bool UniqueChatMode { get; set; }
    }
}
