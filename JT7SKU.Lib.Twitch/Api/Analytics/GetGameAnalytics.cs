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
        public string Game_Id { get; set; }
        public string Type { get; set; }
        public string Started_At { get; set; }
        public string Ended_Át { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record GameAnalyticsResponse
    {
        public GameAnalyticsData Data { get; set; }
        public GameAnalyticsPagination Pagination { get; set; }
    }
    public record GameAnalyticsData
    {
        public string Game_Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public GameAnalyticsDataRange Data_Range { get; set; }
    }
    public record GameAnalyticsDataRange
    {
        public string Started_At { get; set; }
        public string Ended_At { get; set; }
    }
    public record GameAnalyticsPagination 
    {
        public string Cursor { get; set; }
    }
}
