using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Polls
{
    internal class GetPolls
    {
        // Gets a list of polls that the broadcaster created.
        // Polls are available for 90 days after they’re created.
        // Requires a user access token that includes the channel:read:polls or channel:manage:polls scope.
        public string GetPollsChannelReadScope { get; set; } = "channel:read:polls";
        public string GetPollsChannelManageScope { get; set; } = "channel:manage:polls";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/polls"; // GET
        public GetPollsRequestQuery RequestQuery { get; set; }
        public GetPollsResponseBody ResponseBody { get; set; }
        public GetPollsResponseCodes ResponseCodes { get; set; }
    }
    public record GetPollsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public string Id { get; set; }
        public string First { get; set; }
        public string After { get; set; }
    }
    public record GetPollsResponseBody
    {
        public GetPollsRespData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetPollsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401,
        NotFound = 404
    }
    public record GetPollsRespData
    {
        public string Id { set; get; }
        public string BroadcasterId { get; set; }
        public string BroadcasterName { get; set; }
        public string BroadcasterLogin { get; set; }
        public string Title { get; set; }
        public Choices Choices { get; set; }
        public bool BitsVotingEnabled { get; set; }
        public int BitsPerVote { get; set; }
        public bool ChannelPointsVotinEnabled { get; set; }
        public int ChannelPointsPerVote { get; set; }
        public PollsStatus Status { get; set; }
        public int Duration {  get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
    }
}
