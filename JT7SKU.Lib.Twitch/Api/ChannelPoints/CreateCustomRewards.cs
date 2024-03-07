using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using Orleans.Streams;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.ChannelPoints
{
    public class CreateCustomRewards
    {
        public string CreateCustomRewardScope { get; set; } = "channel:manage:redemptions";
        public string ClientID { get; set; }
        public string PathUrl { get; set; } = "/channel_points/custom_rewards";
        public CreateCustomRewardRequestQuery RequestQuery { get; set; }
        public CreateCustomRewardRequestBody RequestBody { get; set; }
        public CreateCustomRewardResponseBody ResponseBody { get; set; }
        public CreateCustomRewardResponseCodes ResponseCodes { get; set; }
    }
    public record CreateCustomRewardRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record CreateCustomRewardRequestBody
    {
        [Required, MaxLength(45)]
        public string Title { get; set; }
        [Required]
        public Int64 Cost { get; set; }
        [MaxLength(200)]
        public string Prompt { get; set; }
        public bool IsEnabled { get; set; }
        public string BackgroundColor { get; set; }
        public bool IsUserInputRequired { get; set; }
        public bool IsMaxPerStreamEnabled { get; set; }
        public int MaxPerStream { get; set; }
        public bool IsMaxPerUserPerStreamEnabled { get; set; }
        public int MaxPerUserPerStream { get; set; }
        public bool IsGlobalCooldownEnabled { get; set; }
        public int GlobalCooldowInSeconds { get; set; }
        public bool ShouldRedemptionsSkipRequestQueue { get; set; }
    }
    public record CreateCustomRewardResponseBody 
    {
        public CreateCustomRewardData Data { get; set; }
    }
    public record CreateCustomRewardData
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
    public enum CreateCustomRewardResponseCodes
    {
        OK=200,
        BadRequest=400,
        Unauthorized=401,
        Forbidden=403,
        InternalServerError=500
    }

}
