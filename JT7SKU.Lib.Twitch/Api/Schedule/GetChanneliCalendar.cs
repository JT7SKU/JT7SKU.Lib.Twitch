using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Schedule
{
    public class GetChanneliCalendar
    {
        // Gets the broadcaster’s streaming schedule as an iCalendar.
        // The Client-Id and Authorization headers are not required.
        public string PathUrl { get; set; } = "/schedule/icalendar";
        public GetChanneliCalendarRequestQuery RequestQuery { get; set; }
        public GetChanneliCalendarResponseBody ResponseBody { get; set; } // responsebody contain iCalendar 
        public GetChanneliCalendarResponseCodes ResponseCodes { get; set; }
    }
    public record GetChanneliCalendarRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record GetChanneliCalendarResponseBody
    {
        public string ContentType = "text/Calendar";
    }
    public enum GetChanneliCalendarResponseCodes
    {
        OK = 200,
        BadRequest = 400
    }
}
