using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Predictions
{
    public class GetPredictions
    {
        //  Gets a list of Channel Points Predictions that the broadcaster created.
        // Requires a user access token that includes the channel:read:predictions or channel:manage:predictions scope.
        public string GetPredictionsChannelReadScope { get; set; } = "channel:read:predictions";
        public string GetPredictionsChannelManageScope { get; set; } = "channel:manage:predictions";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/predictions";
        public GetPredictionsRequestQuery RequestQuery { get; set; }
        public GetPredictionsResponseBody ResponseBody { get; set; }
        public GetPredictionsResponseCodes ResponseCodes { get; set; }
    }
    public record GetPredictionsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public string Id { get; set; }
        public string First {  get; set; }
        public string After { get; set; }
    }
    public record GetPredictionsResponseBody
    {
        public GetPredictionsRespData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetPredictionsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401
    }
    public record GetPredictionsRespData
    {
        public string Id {  set; get; }
        public string BroadcasterId {  set; get; }
        public string BroadcasterName { set; get; }
        public string BroadcasterLogin { set; get; }
        public string Title { set; get; }
        public string WinningOutComeId { set; get; }
        public OutComes OutComes { set; get; }
        public int PredictionWindow {get; set;}
        public PredictionStatus Status { get; set;}
        public DateTime CreatedAt { set; get; }
        public DateTime EndedAt { set; get; }
        public DateTime LockedAt { set; get; }
    }
}
