using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Analytics
{
    public class GetExtensionAnalytics
    {
        public string ExtensionAnalyticsScope { get; set; } = "analytics:read:extensions";
        public string ClientId { get; set; }
        public string Url { get; set; } = "/analytics/extensions";
        public ExtensionAnalyticsRequest ExtensionAnalyticsRequest { get; set; }
        public ExtensionAnalycicsResponse ExtensionAnalycicsResponse { get; set; }

    }
    public record ExtensionAnalyticsRequest
    {
        public string Extension_Id { get; set; }
        public string Type { get; set; }
        public string StartedAt { get; set; }
        public string EndedAt { get; set; }
        public int First { get; set; } = 20;
        public string After { get; set; }
    }
    public record ExtensionAnalycicsResponse
    {
        public ExtensionAnalyticsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public record ExtensionAnalyticsData
    {
        public string Extension_Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; } // type of the report
        public ExtensionAnalyticsRange DataRange { get; set; }
        
    }
    public record ExtensionAnalyticsRange
    {
        public string StartedAt { get; set; }
        public string EndedAt { get; set; }
    }
}
