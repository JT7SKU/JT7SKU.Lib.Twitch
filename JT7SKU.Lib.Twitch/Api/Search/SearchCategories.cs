using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Search
{
    public class SearchCategories
    {
        // Gets the games or categories that match the specified query.
        // To match, the category’s name must contain all parts of the query string. For example, if the query string is 42,
        // the response includes any category name that contains 42 in the title. If the query string is a phrase like love computer,
        // the response includes any category name that contains the words love and computer anywhere in the name.
        // The comparison is case insensitive.
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/search/categories";
        public SearchCategoriesRequestQuery RequestQuery { get; set; }
        public SearchCategoriesResponseBody ResponseBody { get; set; }
        public SearchCategoriesResponseCodes ResponseCodes { get; set; }
    }
    public record SearchCategoriesRequestQuery
    {
        [Required]
        public string Query { get; set; }
        public int First {  get; set; }
        public string After { get; set; }
    }
    public record SearchCategoriesResponseBody
    {
        public List<SearchCategoriesRespData> Data { get; set; }
    }
    public enum SearchCategoriesResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record SearchCategoriesRespData
    {
        public string BoxArtUrl { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
