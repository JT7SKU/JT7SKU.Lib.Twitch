using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Schedule
{
    public class UpdateChannelStreamScheduleSegment
    {
        // Updates a scheduled broadcast segment.
        // For recurring segments, updating a segment’s title, category, duration, and timezone,
        // changes all segments in the recurring schedule, not just the specified segment.
        // Requires a user access token that includes the channel:manage:schedule scope.
        public string UpdateChannelStreamScheduleSegmentChannelManageScope { get; set; } = "channel:manage:schedule";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/schedule/segment";
        public UpdateChannelStreamScheduleSegmentRequestQuery RequestQuery { get; set; }
        public UpdateChannelStreamScheduleSegmentRequestBody RequestBody { get; set; }
        public UpdateChannelStreamScheduleSegmentResponseBody ResponseBody { get; set; }
        public UpdateChannelStreamScheduleSegmentResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateChannelStreamScheduleSegmentRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string Id { get; set; }
    }
    public record UpdateChannelStreamScheduleSegmentRequestBody
    {
        public DateTime StartTime { get; set; }
        public string Duration { get; set; }
        public string CategoryId { get; set; }
        public string Title { get; set; }
        public bool IsCanceled { get; set; }
        public string Timezone { get; set; }
    }
    public record UpdateChannelStreamScheduleSegmentResponseBody
    {
        public UpdateChannelStreamScheduleSegmentRespData Data { get; set; }
    }
    public enum UpdateChannelStreamScheduleSegmentResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401,
        NotFound = 404
    }
    public record UpdateChannelStreamScheduleSegmentRespData
    {
        public List<ScheduleSegment> Segments { get; set; }
        public string BroadcasterId { get; set; }
        public string BroadcasterName { get; set; }
        public string BroadcasterLogin { get; set; }
        public StreamVacation Vacation { get; set; }
    }
}
