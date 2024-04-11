using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Polls
{
    public class CreatePoll
    {
        // Creates a poll that viewers in the broadcaster’s channel can vote on.
        // The poll begins as soon as it’s created. You may run only one poll at a time.
        // Requires a user access token that includes the channel:manage:polls scope.
        public string CreatePollChannelManageScope { get; set; } = "channel:manage:polls";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/polls"; // Post
        public CreatePollRequestBody RequestBody { get; set; }
        public CreatePollResponseBody ResponseBody { get; set; }
        public CreatePollResponseCodes ResponseCodes { get; set; }
    }
    public record CreatePollRequestBody
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public Choices Choices {  set { Title = value.Title; } }
        [Required]
        public int Duration {  get; set; }
        public bool ChannelPointsVotingEnabled { get; set; }
        public int ChannelPointsPerVote { get; set; }
    }
    public record CreatePollResponseBody
    {
        public CreatePollRespData Data { get; set; }
    }
    public enum CreatePollResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401
    }
    public record CreatePollRespData
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
        public int Duration { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
    }
}
