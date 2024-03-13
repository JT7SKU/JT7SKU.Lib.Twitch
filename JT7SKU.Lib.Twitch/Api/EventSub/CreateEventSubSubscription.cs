using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.EventSub
{
    public class CreateEventSubSubscription
    {
        // 3 ifs Webhook to Receive Events, Websockets to receive events and Conduits to receive Events  
        
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/subscriptions";
        public CreateEventSubSubscriptionRequestBody RequestBody { get; set; }
        public CreateEventSubSubscriptionResponseBody ResponseBody { get; set; }
        public CreateEventSubSubscriptionResponseCodes ResponseCodes { get; set; }
    }
    public record CreateEventSubSubscriptionRequestBody
    {
        [Required]
        public SubscriptionType Type { get; set; } // eventSub subscription types
        [Required]
        public string Version { get; set; }
        [Required]
        public SubscriptionCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
        public string ConduitId { get; set; }
    }
    public record CreateEventSubSubscriptionResponseBody
    {
       public CreateEventSubSubscriptionData Data { get; set; }
        public int Total {  get; set; }
        public int TotalCost { get; set; }
        public int MaxTotalCost { get; set; }
    }
    public enum CreateEventSubSubscriptionResponseCodes
    {
        Accepted = 202,
        BadRequest = 400,
        Forbidden = 403,
        Conflict = 409,
        TooManyRequests = 429
    }
    public record CreateEventSubSubscriptionData
    {
        public string Id { get; set; }
        public SubscriptionStatus Status { get; set; } // Subscription Status
        public SubscriptionType Type { get; set;}
        public string Version { get; set; }
        public SubscriptionCondition Condition { get; set; } // The subscription’s parameter values. This is a string-encoded JSON object whose contents are determined by the subscription type.
        public Transport Transport { get; set; }
        public string ConduitId { get; set; }
        public int Cost { get; set; }
    }
}
