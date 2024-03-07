using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.ChannelPoints
{
    public class GetCustomRewardRedemption
    {
        public string CustomRewardRedemptionReadScope { get; set; } = "channel:read:redemptions"; //this or manage scope
        public string CustomRewardredemptionManageScope { get; set; } = "channel:manage:redemptions ";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channel_points/custom_rewards";
        public GetCustomRewardRedemptionRequestQuery RequestQuery { get; set; }
        public GetCustomRewardRedemptionResonseBody ResonseBody { get; set; }
        public GetCustomRewardRedemptionResponseCodes ResponseCodes { get; set; }
    }
    public record GetCustomRewardRedemptionRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string RewardId { get; set; }
        [Required]
        public RedemptionStatus Status { get; set; }
        public string Id { get; set; }
        public string Sort { get; set; }
        public string After { get; set; }
        public int First { get; set; }
    }
    public record GetCustomRewardRedemptionResonseBody
    {
        public GetCustomRewardRedemptionData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public record GetCustomRewardRedemptionData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string UserInput { get; set; }
        public RedemptionStatus Status { get; set; }
        public string RedeemendAt { get; set; }
        public Reward Reward { get; set; }
    }
    public enum GetCustomRewardRedemptionResponseCodes
    {
        OK= 200,
        BadRequest=400,
        Forbidden=403,
        NotFound=404,
        InternalServerError=500
    }
}
