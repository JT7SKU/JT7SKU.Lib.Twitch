using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.ChannelPoints
{
    public class UpdateRedemptionStatus
    {
        public string UpdateCustomRewardManageScope { get; set; } = "channel:manage:redemptions ";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channel_points/custom_rewards/redemptions";
        public UpdateRedemptionStatusRequestQuery RequestQuery { get; set; }

    }
    public record UpdateRedemptionStatusRequestQuery
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string RewardId { get; set; }
    }
    public record UpdateRedemptionStatusRequestBody
    {
        [Required]
        public RedemptionStatus Status { get; set; } // minus UNFILLED
    }
    public record UpdateRedemptonStatusResponseBody
    {
        public UpdateRedemptionStatusData Data { get; set; }
    }
    public enum UpdateRedemptionStatusResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        InternalServerError = 500
    }
    public record UpdateRedemptionStatusData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public Reward Reward { get; set; }
        public string UserInput { get; set; }
        public RedemptionStatus Status { get; set; }
        public string RedeemedAt { get; set; }
    }
}
