using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Games
{
    public class GetGames
    {
        // requires App Access Token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/games";
        public GetGamesRequestQuery RequestQuery { get; set; }
        public GetGamesResponseBody ResponseBody { get; set; }
        public GetGamesResponseCodes ResponseCodes { get; set; }
    }
    public record GetGamesRequestQuery
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string IGdbId { get; set; }
    }
    public record GetGamesResponseBody
    {
        public GetGamesData Data { get; set; }
    }
    public enum GetGamesResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetGamesData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BoxArtUrl { get; set; }
        public string IGdbId { get; set; }
    }
}
