using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Channels
{
    public class GetChannelInformation
    {
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channels";
        public ChannelInformationRequestBody ChannelInformationRequestBody { get; set; }
        public ChannelInformationResponseBody ChannelInformationResponseBody { get; set; }
    }
    public record ChannelInformationRequestBody
    {
        public string BroadcasterId { get; set; }
    }
    public record ChannelInformationResponseBody
    {
        public ChannelInformationData Data { get; set; }
    }
    public record ChannelInformationData
    {
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string BroadcasterLanguage { get; set; }
        public string GameName { get; set; }
        public string GameId { get; set; }
        public string Title { get; set; }
        public uint Delay { get; set; }
        public string ContentClassificationlabels { get; set; }
        public bool IsBrandedContent { get; set; }
    }
}
