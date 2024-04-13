using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Teams
{
    public class GetTeams
    {
        // Gets information about the specified Twitch team.
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/teams";
        public GetTeamsRequestQuery RequestQuery { get; set; }
        public GetTeamsResponseBody ResponseBody { get; set; }
        public GetTeamsResponseCodes ResponseCodes { get; set; }
    }
    public record GetTeamsRequestQuery
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Id { get; set; }
    }
    public record GetTeamsResponseBody
    {
        public List<GetTeamsRespData> Data { get; set; }
    }
    public enum GetTeamsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
    public record GetTeamsRespData
    {
        public List<User> Users { get; set; }
        public string BackgroundImageUrl { get; set; }
        public string Banner { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Info { get; set; }
        public string ThumbnailUrl { get; set; }
        public string TeamName { get; set; }
        public string TeamDisplayName { get; set; }
        public string Id { get; set; }
    }
