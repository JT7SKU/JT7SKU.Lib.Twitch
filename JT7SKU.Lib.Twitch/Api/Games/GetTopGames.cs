using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Games
{
    public class GetTopGames
    {
        // Requires App Access token or User Access token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/games/top";
        public GetTopGamesRequestQuery RequestQuery { get; set; }
        public GetTopGamesResponseBody ResponseBody { get; set; }
        public GetTopGamesResponseCodes ResponseCodes { get; set; }
    }
    public record GetTopGamesRequestQuery
    {
        public int First { get; set; }
        public string After { get; set; }
        public string Before { get; set; }
    }
    public record GetTopGamesResponseBody
    {
        public GetTopGamesData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetTopGamesResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetTopGamesData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BoxArtUrl { get; set; }
        public string IGdbId { get; set; }
    }
}
