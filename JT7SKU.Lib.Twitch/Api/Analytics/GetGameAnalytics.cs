using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Analytics
{
    public class GetGameAnalytics
    {
        public string GameAnalyticsScope { get; set; } = "analytics:read:games";
        public string ClientId { get; set; }
        public string Url { get; set; } = "/analytics/games";
        public GameAnalyticsRequest GameAnalyticsRequestBody { get; set; }
        public GameAnalyticsResponse GameAnalyticsResponseBody { get; set; }

    }
    public record GameAnalyticsRequest
    {
        public string GameId { get; set; }
        public string Type { get; set; }
        public string StartedAt { get; set; }
        public string EndedÁt { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record GameAnalyticsResponse
    {
        public GameAnalyticsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public record GameAnalyticsData
    {
        public string GameId { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public GameAnalyticsDataRange DataRange { get; set; }
    }
    public record GameAnalyticsDataRange
    {
        public string StartedAt { get; set; }
        public string EndedAt { get; set; }
    }
}
