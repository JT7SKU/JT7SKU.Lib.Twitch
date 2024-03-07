using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.ChannelPoints
{
    public class UpdateCustomReward
    {
        public string UpdateCustomRewardManageScope { get; set; } = "channel:manage:redemptions ";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channel_points/custom_rewards";
        public UpdateCustomRewardRequestQuery RequestQuery { get; set; }
        public UpdateCustomRewardRequestBody RequestBody { get; set; }
        public UpdateCustomRewardResponseBody ResponseBody { get; set; }
        public UpdateCustomRewardResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateCustomRewardRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string Id { get; set; }
    }
    public record UpdateCustomRewardRequestBody
    {
        public string Title { get; set; }
        [MaxLength(200)]
        public string Prompt { get; set; }
        public Int64 Cost { get; set; }
        public string BackgroundColor { get; set; } // hex color code
        public bool IsEnabled { get; set; }
        public bool IsUserInputRequired { get; set; }
        public bool IsMaxPerStreamEnabled { get; set; }
        public Int64 MaxPerStream { get; set; }
        public bool IsMaxPerUserPerStreamEnabled { get; set; }
        public Int64 MaxPerUserPerStream { get; set; }
        public bool IsGlobalCooldownEnabled { get; set; }
        public Int64 GlobalCooldownSeconds { get; set; }
        public bool IsPaused { get; set; }
        public bool ShouldRedemptionsSkipRequestQueue { get; set; }
    }
    public record UpdateCustomRewardResponseBody
    {
        public  UpdateCustomRewardData Data { get; set; }
    }
    public enum UpdateCustomRewardResponseCodes
    {
        OK=200,
        BadRequest=400,
        Unauthorized=401,
        Forbidden=403,
        NotFound=404,
        InternalServerError=500
    }
    public record UpdateCustomRewardData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Prompt { get; set; }
        public int Cost { get; set; }
        public Image Image { get; set; }
        public Image DefaultImage { get; set; }
        public string BackgroundColor { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsUserInputEnabled { get; set; }
        public MaxPerStream MaxPerStreamSetting { get; set; }
        public MaxPerUserPerStream MaxPerUserPerStreamSetting { get; set; }
        public GlobalCooldown GlobalCooldownSetting { get; set; }
        public bool IsPaused { get; set; }
        public bool IsInStock { get; set; }
        public bool ShouldRedemptionsSkipRequestQueue { get; set; }
        public int RedemptionsRedeemedCurrentStream { get; set; }
        public string CooldownExpiresAt { get; set; }
    }
}
