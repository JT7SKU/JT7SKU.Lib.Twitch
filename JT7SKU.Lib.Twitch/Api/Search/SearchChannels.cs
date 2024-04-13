using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Search
{
    public class SearchChannels
    {
        // Gets the channels that match the specified query and have streamed content within the past 6 months.
        // The fields that the API uses for comparison depends on the value that the live_only query parameter is set to.
        // If live_only is false, the API matches on the broadcaster’s login name.
        // However, if live_only is true, the API matches on the broadcaster’s name and category name.
        // To match, the beginning of the broadcaster’s name or category must match the query string. The comparison is case insensitive.
        // If the query string is angel_of_death, it matches all names that begin with angel_of_death.
        // However, if the query string is a phrase like angel of death, it matches to names starting with angelofdeath or names starting with angel_of_death.
        // By default, the results include both live and offline channels. To get only live channels set the live_only query parameter to true.
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/search/channels";
        public SearchChannelsRequestQuery RequestQuery { get; set; }
        public SearchChannelsResponseBody ResponseBody { get; set; }
        public SearchChannelsResponseCodes ResponseCodes { get; set; }
    }
    public record SearchChannelsRequestQuery
    {
        [Required]
        public string Query { get; set; }
        public bool LiveOnly { get; set; }
        public int First {  get; set; }
        public string After { get; set; }
    }
    public record SearchChannelsResponseBody
    {
        public List<SearchChannelsRespData> Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum SearchChannelsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record SearchChannelsRespData
    {
        public string BroadcasterLanguage { get; set; }
        public string BroadcasterLogin { get; set; }
        public string DisplayName { get; set; }
        public string GameId { get; set; }
        public string Id { get; set; }
        public bool IsLive {  get; set; }
        public string[] TagIds { get; set; }
        public string[] Tags {  get; set; }
        public string ThumbnailUrl { get; set; }
        public string Title { get; set; }
        public DateTime StartedAt { get; set; }
    }
}
