using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.EventSub
{
    public class GetEventSubSubscriptions
    {
        // Webhooks or Conduits to receive events you need App access token, User acces token for Websockets to receive events
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/subscriptions";
        public GetEventSubSubscriptionsRequestQuery RequestQuery { get; set; }
        public GetEventSubSubscriptionsResponseBody ResponseBody { get; set; }
        public GetEventSubSubscriptionsResponseCodes ResponseCodes { get; set; }
    }
    public record GetEventSubSubscriptionsRequestQuery
    {
        public SubscriptionStatus Status { get; set; }
        public SubscriptionType Type { get; set; }
        public string UserId { get; set; }
        public string After {  get; set; }
    }
    public record GetEventSubSubscriptionsResponseBody
    {
        public GetEventSubSubscriptionData Data { get; set; }
        public int Total { get; set; }
        public int TotalCost { get; set; }
        public int MaxTotalCost { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetEventSubSubscriptionsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetEventSubSubscriptionData
    {
        public string Id { get; set; }
        public SubscriptionStatus Status { get; set;}
        public SubscriptionType Type { get; set;}
        public string Version { get; set;}
        public SubscriptionCondition Condition { get; set;}
        public DateTime CreatedAt { get; set; }
        public Transport Transport { get; set;}
        public int Cost { get; set;}
    }
}
