using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Ads
{
    public class StartCommercial
    {
        public string CommercialScope { get; set; } = " channel:edit:commercial";
        public string ClientId { get; set; }
        public string url { get; set; } = "helix/channels/commercial";
        public CommercialRequestBody RequestBody { get; set; }
        public CommersialResponseBody ResponseBody { get; set; }
    }
    public record CommercialRequestBody
    {
        public string BroadcasterId { get; set; } //broadcaster_id
        public int Lenght { get; set; } //lenght
    }
    public record CommersialResponseBody
    {
        public Commercial Data { get; set; }
    }
    public record Commercial
    {
        public int Lenght { get; set; }
        public string Message { get; set; }
        public int Retry_After { get; set; }
    }
}
