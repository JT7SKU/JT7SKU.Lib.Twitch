using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Schedule
{
    public class DeleteChannelStreamScheduleSegment
    {
        // Removes a broadcast segment from the broadcaster’s streaming schedule.
        // NOTE: For recurring segments, removing a segment removes all segments in the recurring schedule.
        // Requires a user access token that includes the channel:manage:schedule scope.
        public string DeleteChannelStreamScheduleSegmentChannelManageScope { get; set; } = "channel:manage:schedule";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/schedule/segment";
        public DeleteChannelStreamScheduleSegmentRequestQuery RequestQuery { get; set; }
        public DeleteChannelStreamScheduleSegmentResponseCodes ResponseCodes { get; set; }
    }
    public record DeleteChannelStreamScheduleSegmentRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string Id { get; set; }
    }
    public enum DeleteChannelStreamScheduleSegmentResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401
    }
}
