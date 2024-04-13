using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Subsctiptions
{
    public class GetBroadcasterSubscriptions
    {
        //  Gets a list of users that subscribe to the specified broadcaster.
        // Requires a user access token that includes the channel:read:subscriptions scope.
        // A Twitch extensions may use an app access token if the broadcaster has granted the channel:read:subscriptions scope from within the Twitch Extensions manager.
        public string GetBroadcasterSubscriptionsChannelReadScope { get; set; } = "channel:read:subscriptions";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/subscriptions";
        public GetBroadcasterSubscriptionsRequestQuery RequestQuery { get; set; }
        public GetBroadcasterSubscriptionsResponseBody ResponseBody { get; set; }
        public GetBroadcasterSubscriptionsResponseCodes ResponseCodes { get; set; }
    }
    public record GetBroadcasterSubscriptionsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public string UserId { get; set; }
        public string First {  get; set; }
        public string After { get; set; }
        public string Before { get; set; }
    }
    public record GetBroadcasterSubscriptionsResponseBody
    {
        public List<GetBroadcasterSubscriptionRespData> Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetBroadcasterSubscriptionsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetBroadcasterSubscriptionRespData
    {
        public string BroadcasterId { get; set;}
        public string BroadcasterLogin { get; set;}
        public string BroadcasterName { get; set;}
        public string GifterId { get; set;}
        public string GifterName { get; set;}
        public bool IsGift { get; set;}
        public string PlanName { get; set;}
        public SubscriberType Tier { get; set;}
        public string UserId { get; set;}
        public string UserName { get; set;}
        public string UserLogin { get; set;}
    }
}
