using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class SendChatAnnouncement
    {
        public string SendChatAnnouncementScope { get; set; } = "moderator:manage:announcements";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/announcements";
        public SendChatAnnouncementRequestQuery RequestQuery { get; set; }
        public SendChatAnnouncementRequestBody RequestBody { get; set; }
        public SendChatAnnouncementResponseCodes ResponseCodes { get; set; }
    }
    public record SendChatAnnouncementRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record SendChatAnnouncementRequestBody
    {
        [Required, MaxLength(500)]
        public string Message { get; set; }
        public string Color { get; set; }
    }
   
    public enum SendChatAnnouncementResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
   
}
