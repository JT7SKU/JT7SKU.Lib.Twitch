using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Schedule
{
    public class CreateChannelStreamScheduleSegment
    {
        // Adds a single or recurring broadcast to the broadcaster’s streaming schedule. For information about scheduling broadcasts, see Stream Schedule.
        // Requires a user access token that includes the channel:manage:schedule scope.
        public string CreateChannelStreamScheduleSegmentChannelManageScope { get; set; } = "channel:manage:schedule";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/schedule/segment";
        public CreateChannelStreamScheduleSegmentRequestQuery RequestQuery { get; set; }
        public CreateChannelStreamScheduleSegmentRequestBody RequestBody { get; set; }
        public CreateChannelStreamScheduleSegmentResponseBody ResponseBody { get; set; }
        public CreateChannelStreamScheduleSegmentResponseCodes ResponseCodes { get; set; }
    }
    public record CreateChannelStreamScheduleSegmentRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record CreateChannelStreamScheduleSegmentRequestBody
    {
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public string Timezone { get; set; }
        [Required]
        public string Duration { get; set; }// in minutes 
        public bool IsRecurring { get; set; }
        public string CategoryId { get; set; }
        public string Title { get; set; }
    }
    public record CreateChannelStreamScheduleSegmentResponseBody
    {
        public CreateChannelStreamScheduleSegmentRespData Data { get; set; }
    }
    public enum CreateChannelStreamScheduleSegmentResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record CreateChannelStreamScheduleSegmentRespData
    {
        public List<ScheduleSegment> Segments { get; set; }
        public string BroadcasterId { get; set; }
        public string BroadcasterName { get; set; }
        public string BroadcasterLogin { get; set; }
        public StreamVacation Vacation { get; set; }
    }
}
