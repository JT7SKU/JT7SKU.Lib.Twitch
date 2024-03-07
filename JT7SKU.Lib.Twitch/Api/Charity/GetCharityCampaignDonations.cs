using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Charity
{
    public class GetCharityCampaignDonations
    {
        public string GetCharityCampaignDonationsScope { get; set; } = "channel:read:charity";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/charity/donations";
        public GetCharityCampaignDonationsRequestQuery RequestQuery { get; set; }
        public GetCharityCampaignDonationsResponseBody ResponseBody { get; set; }
        public GetCharityCampaignDonationsResponseCodes ResponseCodes { get; set; }
    }
    public record GetCharityCampaignDonationsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public int Fist { get; set; }
        public string After { get; set; }
    }
    public record GetCharityCampaignDonationsResponseBody
    {
        public GetCharityCampaignDonationsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetCharityCampaignDonationsResponseCodes
    {
        OK=200,
        BadRequest=400,
        Unauthorized=401,
        Forbidden=403
    }
    public record GetCharityCampaignDonationsData
    {
        public string Id { get; set; }
        public string CampaignId { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public Amount Amount { get; set; }
    }
}
