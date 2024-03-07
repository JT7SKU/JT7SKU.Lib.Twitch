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
        public string Broadcaster_Id { get; set; }
    }
    public record ChannelInformationResponseBody
    {
        public ChannelInformationData Data { get; set; }
    }
    public record ChannelInformationData
    {
        public string Broadcaster_Id { get; set; }
        public string Broadcaster_Login { get; set; }
        public string Broadcaster_Name { get; set; }
        public string Broadcaster_Language { get; set; }
        public string Game_Name { get; set; }
        public string Game_Id { get; set; }
        public string Title { get; set; }
        public uint Delay { get; set; }
        public string ContentClassificationlabels { get; set; }
        public bool IsBrandedContent { get; set; }
    }
}
