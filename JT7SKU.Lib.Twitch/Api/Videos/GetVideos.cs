using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Videos
{
    public class GetVideos
    {
        // Gets information about one or more published videos. You may get videos by ID, by user, or by game/category.
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/videos";
        public GetVideosRequestQuery RequestQuery { get; set; }
        public GetVideosResponseBody ResponseBody { get; set; }
        public GetVideosResponseCodes ResponseCodes { get; set; }
    }
    public record GetVideosRequestQuery
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string GameId { get; set; }
        public string Language {  get; set; }
        public VideosPeriodFilter Period {  get; set; }
        public VideosShorting Sort { get; set; }
        public VideoType Type { get; set; }
        public string First {  get; set; }
        public string after { get; set; }
        public string Before { get; set; }
    }
    public record GetVideosResponseBody
    {
        public List<GetVideosRespData> Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetVideosResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauhtorized = 401,
        NotFound = 404,
    }
    public record GetVideosRespData
    {
        public string Id { get; set; }
        public string StreamId { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Viewable {  get; set; }
        public int ViewCount { get; set; }
        public string Language { get; set; }
        public VideoType Type { get; set; }
        public string Duration { get; set; }
        public List<MutedSegments> MutedSegments { get; set; }
    }
}
