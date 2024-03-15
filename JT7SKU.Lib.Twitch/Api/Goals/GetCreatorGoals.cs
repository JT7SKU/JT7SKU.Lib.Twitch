using JT7SKU.Lib.Twitch.EventSub;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Goals
{
    public class GetCreatorGoals
    {
        //requires user access token
        public string GetCreatorGoalsReadScope { get; set; } = "channel:read:goals";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/goals";
        public GetCreatorGoalsRequestQuery RequestQuery { get; set; }
        public GetCreatorGoalsResponseBody ResponseBody { get; set; }
        public GetCreatorGoalsResponseCodes ResponseCodes { get; set; }
    }
    public record GetCreatorGoalsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record GetCreatorGoalsResponseBody
    {
        public GetCreatorGoalsData Data { get; set; }
    }
    public enum GetCreatorGoalsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetCreatorGoalsData
    {
        public string Id { get; set; }
        public string BroadcasterId { get; set;}
        public string BroadcasterName { get; set;}
        public string BroadcasterLogin { get; set;}
        public GoalType GoalType { get; set;}
        public string Description { get; set;}
        public int CurrentAmount { get; set;}
        public int TargetAmount { get; set;}
        public DateTime CreatedAt { get; set;}
    }
}
