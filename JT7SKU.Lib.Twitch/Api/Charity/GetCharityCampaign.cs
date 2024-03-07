using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Charity
{
    public class GetCharityCampaign
    {
        public string GetCharityCampaignScope { get; set; } = "channel:read:charity";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/charity/campaigns";
        public GetCharityCampaignRequestQuery RequestQuery { get; set; }
    }
    public record GetCharityCampaignRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record GetCharityCampaignResponseBody
    {
        public GetCharityCampaignData Data { get; set; }
    }
    public enum GetCharityCampaignResponseCodes
    {
        OK=200,
        BadRequest=400,
        Unauthorized=401,
        Forbidden=403
    }
    public record GetCharityCampaignData
    {
        public string Id { get; set; }
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string CharityName { get; set; }
        public string CharityDescription { get; set; }
        public string CharityLogo { get; set; }
        public string CharityWebsite { get; set; }
        public Amount CurrentAmount { get; set; }
        public Amount TargetAmount { get; set; }
    }
}
