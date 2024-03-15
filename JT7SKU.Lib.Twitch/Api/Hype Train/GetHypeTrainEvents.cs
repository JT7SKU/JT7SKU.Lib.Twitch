using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Hype_Train
{
    public class GetHypeTrainEvents
    {
        // Requires a user access token that includes the channel:read:hype_train scope.
        public string GetHypeTrainEventsChnnelreadScope { get; set; } = "channel:read:hype_train";
        public string ClientId { get; set; }
        public string PathName { get; set; } = "/hypetrain/events";
        public GetHypeTrainEventsRequestQuery RequestQuery { get; set; }
        public GetHypeTrainEventsResponseBody ResponseBody { get; set; }
        public GetHypeTrainEventsResponseCodes ResponseCodes { get; set; }
    }
    public record GetHypeTrainEventsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record GetHypeTrainEventsResponseBody
    {
        public GetHypeTrainEventsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetHypeTrainEventsResponseCodes
    {
        OK = 200,
        Unauthorized = 401
    }
    public record GetHypeTrainEventsData
    {
        public string Id { get; set; }
        public string EventType { get; set; } // hypetrain.progression
        public DateTime EventTimestamp { get; set; }
        public string Version { get; set; }
        public HypeTrainEventData EventData { get; set; }
    }
}
