using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.EventSub
{
    public class DeleteEventSubSubscription
    {
        // webhookcs and websockets
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/eventsub/subscriptions";
        public DeleteEventSubSubscriptionRequestQuery RequestQuery { get; set; }
        public DeleteEventSubSubscriptionResponseCodes ResponseCodes { get; set; }
    }
    public record DeleteEventSubSubscriptionRequestQuery
    {
        [Required]
        public string Id { get; set; } // Íd of hte subscription to delete
    }
    public enum DeleteEventSubSubscriptionResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
}
