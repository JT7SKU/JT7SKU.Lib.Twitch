using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Subsctiptions
{
    public class CheckUserSubscriptions
    {
        // Checks whether the user subscribes to the broadcaster’s channel.
        // Requires a user access token that includes the user:read:subscriptions scope.
        // A Twitch extensions may use an app access token if the broadcaster has granted the user:read:subscriptions scope from within the Twitch Extensions manager.
        public string CheckUserSubscriptionsUserReadScope { get; set; } = "user:read:subscriptions";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/subscriptions/user";
        public CheckUserSubscriptionsRequestQuery RequestQuery { get; set; }
        public CheckUserSubscriptionsResponseBody ResponseBody { get; set; }
        public CheckUserSubscriptionsResponseCodes ResponseCodes { get; set; }
    }
    public record CheckUserSubscriptionsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string UserId { get; set; }
    }
    public record CheckUserSubscriptionsResponseBody
    {
        public List<CheckUserSubscriptionRespData> Data { get; set; }
    }
    public enum CheckUserSubscriptionsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
    public record CheckUserSubscriptionRespData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string GifterId { get; set; }
        public string GifterLogin { get; set; }
        public string GifterName { get; set; }
        public bool IsGift { get; set; }
        public SubscriberType Tier { get; set; }
}
