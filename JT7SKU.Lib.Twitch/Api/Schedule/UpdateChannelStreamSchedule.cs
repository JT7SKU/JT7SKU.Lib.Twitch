using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Schedule
{
    public class UpdateChannelStreamSchedule
    {
        // Updates the broadcaster’s schedule settings, such as scheduling a vacation.
        // Requires a user access token that includes the channel:manage:schedule scope.
        public string UpdateChannelStreamScheduleChannelManageScheduleScope { get; set; } = "channel:manage:schedule";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/schedule/settings";
        public UpdateChannelStreamScheduleRequestQuery RequestQuery { get; set; }
        public UpdateChannelStreamScheduleResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateChannelStreamScheduleRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public bool IsVacationEnabled { get; set; }
        public DateTime VacationStartTime { get; set; }
        public DateTime VacationEndTime { get; set; }
        public string Timezone { get; set; }
    }
    public enum UpdateChannelStreamScheduleResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        UnAuthorized = 401,
        NotFound = 404
    }
}
