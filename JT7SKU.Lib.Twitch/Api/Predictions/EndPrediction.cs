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
    public class EndPrediction
    {
        // Locks, resolves, or cancels a Channel Points Prediction.
        // Requires a user access token that includes the channel:manage:predictions scope.
        public string EndPredictionChannelManageScope { get; set; } = "channel:manage:predictions";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/predictions"; 
        public EndPredictionRequestBody RequestBody { get; set; }
        public EndPredictionResponseBody ResponseBody { get; set; }
        public EndPredictionResponseCodes ResponseCodes { get; set; }
    }
    public record EndPredictionRequestBody
    {
        [Required]
        public string BroacasterId { get; set; }
        [Required]
        public string Id { get; set; }
        [Required]
        public PredictionStatus Status { get; set; }
        public string WinningOutcomeId { get; set; }
    }
    public record EndPredictionResponseBody
    {
        public EndPredictionRespData Data { get; set; }
    }
    public enum EndPredictionResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
    public record EndPredictionRespData
    {
        public string Id { set; get; }
        public string BroadcasterId { set; get; }
        public string BroadcasterName { set; get; }
        public string BroadcasterLogin { set; get; }
        public string Title { set; get; }
        public string WinningOutComeId { set; get; }
        public OutComes OutComes { set; get; }
        public int PredictionWindow { get; set; }
        public PredictionStatus Status { get; set; }
        public DateTime CreatedAt { set; get; }
        public DateTime EndedAt { set; get; }
        public DateTime LockedAt { set; get; }
    }
}
