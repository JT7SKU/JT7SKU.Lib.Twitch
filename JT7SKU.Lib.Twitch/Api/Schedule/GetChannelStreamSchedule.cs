using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Schedule
{
    internal class GetChannelStreamSchedule
    {
        // Gets the broadcaster’s streaming schedule.You can get the entire schedule or specific segments of the schedule.
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/schedule";
        public GetChannelStreamScheduleRequestQuery RequestQuery { get; set; }
        public GetChannelStreamScheduleResponseBody ResponseBody { get; set; }
        public GetChannelStreamScheduleResponseCodes ResponseCodes { get; set; }
    }
    public record GetChannelStreamScheduleRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public string UTCOffset { get; set; } // not supported
        public int First {  get; set; }
        public string After { get; set; }
    }
    public record GetChannelStreamScheduleResponseBody
    {
        public GetChannelStreamScheduleRespData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetChannelStreamScheduleResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401,
        Forbidden = 403,
        NotFound = 404
    }
    public record GetChannelStreamScheduleRespData
    {
        public List<ScheduleSegment> Segments { get; set; }
        public string BroadcasterId { get; set; }
        public string BroadcasterName { get; set; }
        public string BroadcasterLogin { get; set; }
        public StreamVacation Vacation { get; set; }
    }
}
