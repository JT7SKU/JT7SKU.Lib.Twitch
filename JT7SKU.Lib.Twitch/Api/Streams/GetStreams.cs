using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Streams
{
    public class GetStreams
    {
        // Gets a list of all streams.
        // The list is in descending order by the number of viewers watching the stream.
        // Because viewers come and go during a stream, it’s possible to find duplicate or missing streams in the list as you page through the results.
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/streams";
        public GetStreamsRequestQuery RequestQuery { get; set; }
        public GetStreamsResponseBody ResponseBody { get; set; }
        public GetStreamsResponseCodes ResponseCodes { get; set; }
    }
    public record GetStreamsRequestQuery
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string GameId { get; set; }
        public StreamType Type { get; set; }
        public string Language { get; set; }
        public int First {  get; set; }
        public string Before { get; set; }
        public string After { get; set; }
    }
    public record GetStreamsResponseBody
    {
        public List<GetStreamsRespData> Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetStreamsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetStreamsRespData
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string GameId { get; set; }
        public string GameName { get; set; }
        public StreamType Type { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public int ViewerCount { get; set; }
        public DateTime StartedAt { get; set; }
        public string Language { get; set; }
        public string ThumbnailUrl { get; set; }
        public string[] TagsIds { get; set; }
        public bool IsMature { get; set; }
    }
}
