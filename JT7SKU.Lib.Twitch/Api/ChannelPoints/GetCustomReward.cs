using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.ChannelPoints
{
    public class GetCustomReward
    {
        public string CustomRewardReadScope { get; set; } = "channel:read:redemptions"; //this or manage scope
        public string CustomRewardManageScope { get; set; } = "channel:manage:redemptions ";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channel_points/custom_rewards";
        public GetCustomRewardRequestQuery RequestQuery { get; set; }
        public GetCustomRewardResponseBody ResponseBody { get; set; }
        public GetCustomRewardResponseCodes ResponseCodes { get; set; }
    }
    public record GetCustomRewardRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public string Id { get; set; }
        public bool OnlyManageableRewards { get; set; }
    }
    public record GetCustomRewardResponseBody
    {
        public GetCustomRewardData Data { get; set; }
    }
    public record GetCustomRewardData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Prompt { get; set; }
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
    public enum GetCustomRewardResponseCodes
    {
        OK=200,
        BadRequest=400,
        Unauthorized=401,
        Forbidden=403,
        NotFound=404,
        InternalServerError=500
    }
}
