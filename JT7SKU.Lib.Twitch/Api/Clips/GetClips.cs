using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Clips
{
    public class GetClips
    {
        // Authorized App Access Token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; }
        public GetClipsRequestQuery RequestQuery { get; set; }
        public GetClipsResponseBody ResponseBody { get; set; }
        public GetClipsResponseCodes ResponseCodes { get; set; }
    }
    public record GetClipsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string GameId { get; set; }
        [Required]
        public string Id { get; set; }
        public string StartedAt { get; set; }
        public string EndedAt { get; set; }
        public int First {  get; set; }
        public string Before { get; set; }
        public string After { get; set; }
        public bool IsFeatured { get; set; }

    }
    public record GetClipsResponseBody
    {
        public GetClipsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetClipsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401,
        NotFound = 404
    }
    public record GetClipsData
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string BroadcasterId { get; set; }
        public string BroadcasterName { get; set; }
        public string CreatorId { get; set; }
        public string CreatorName { get; set; }
        public string VideoId { get; set; }
        public string GameId { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public int ViewCount { get; set; }
        public string CreatedAt { get; set; }
        public string ThumbnailUrl { get; set; }
        public float Duration { get; set; }
        public int VodOffset { get; set; }
        public bool IsFeatured { get; set; }
    }
}
