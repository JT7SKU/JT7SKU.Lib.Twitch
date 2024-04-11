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
    public class EndPoll
    {
        // Ends an active poll. You have the option to end it or end it and archive it.
        // Requires a user access token that includes the channel:manage:polls scope.
        public string EndPollChannelManageScope { get; set; } = "channel:manage:polls";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/polls"; // Patch
        public EndPollRequestBody RequestBody { get; set; }
        public EndPollResponseBody ResponseBody { get; set; }
        public EndPollResponseCodes ResponseCodes { get; set; }
    }
    public record EndPollRequestBody
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string Id { get; set; }
        [Required]
        public PollsStatus Status { get; set; }
    }
    public record EndPollResponseBody
    {
        public EndPollRespData Data { get; set; }
    }
    public enum EndPollResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401
    }
    public record EndPollRespData
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
