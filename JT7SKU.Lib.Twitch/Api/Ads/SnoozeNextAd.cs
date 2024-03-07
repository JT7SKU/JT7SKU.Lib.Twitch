using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Ads
{
    public class SnoozeNextAd
    {
        public string SnoozeNextScope { get; set; } = "channel:manage:ads";
        public string ClientId { get; set; }
        public string UserId { get; set; }
        public string BroadcasterId { get; set; }
        public string Url { get; set; } = "";
        public NextSnoozeRequestBody SnoozeRequestBody { get; set; }
        public NextSnoozeResponseBody SnoozeResponseBody { get; set; }
    }
    public record NextSnoozeRequestBody
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record NextSnoozeResponseBody
    {
        public NextSnooze Data { get; set; }
    }
    public record NextSnooze
    {
        public int Snooze_Count { get; set; }
        public string Snooze_Refresh_At { get; set; }
        public string Next_Ad_At { get; set; }
    }
}
