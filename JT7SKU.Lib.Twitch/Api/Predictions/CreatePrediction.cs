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
    public class CreatePrediction
    {
        //  Creates a Channel Points Prediction.
        // With a Channel Points Prediction, the broadcaster poses a question and viewers try to predict the outcome.
        // The prediction runs as soon as it’s created. The broadcaster may run only one prediction at a time.
        // Requires a user access token that includes the channel:manage:predictions scope.
        public string CreatePredictionChannelManageScope { get; set; } = "channel:manage:predictions";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/predictions";
        public CreatePredictionRequestQuery RequestQuery { get; set; }
        public CreatePredictionResponseBody ResponseBody { get; set; }
        public CreatePredictionResponseCodes ResponseCodes { get; set; }
    }
    public record CreatePredictionRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required, MaxLength(45)]
        public string Title { get; set; }
        [Required]
        public OutComes OutComes { set { Title = value.Title; } } // max 10 
        [Required]
        public int PredictionWindow {  get; set; }
    }
    public record CreatePredictionResponseBody
    {
        public CreatePredictionData Data { get; set; }
    }
    public enum CreatePredictionResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401,
        TooManyRequest = 429
    }
    public record CreatePredictionData
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
