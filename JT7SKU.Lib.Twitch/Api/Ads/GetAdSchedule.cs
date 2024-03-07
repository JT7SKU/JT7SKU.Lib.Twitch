using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Ads
{
    public class GetAdSchedule
    {
        public string AdScheduleScope { get; set; } = "channel:read:ads";
        public string ClientId { get; set; }
        public string UserId { get; set; }
        public string BroadcasterId { get; set; }
        public string Url { get; set; } = "/helix/channels/ads";
        public AdScheduleRequestBody AdScheduleRequestBody { get; set; }
        public AddScheduleResponseBody AddScheduleResponseBody { get; set; }
    }
    public record AdScheduleRequestBody
    {
        [Required]
        public string BroadcasterId { get; set; } // must be match UserId 
    }
    public record AddScheduleResponseBody
    {
        public ScheduledAd Data { get; set; }
    }
    public record ScheduledAd 
    {
        public int SnoozeCount { get; set; }
        public string SnoozeRefreshAt { get; set; }
        public string NextAdAt { get; set; }
        public int Duration { get; set; }
        public string LastAdAt { get; set; }
        public int PreRoll_Free_Time { get; set; }
    }

}
