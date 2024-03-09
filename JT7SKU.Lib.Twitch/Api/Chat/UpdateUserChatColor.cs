using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class UpdateUserChatColor
    {
        public string UpdateUserChatColorScope { get; set; } = "user:manage:chat_color";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/color";
        public UpdateUserChatColorRequestQuery RequestQuery { get; set; }
        public UpdateUserChatColorResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateUserChatColorRequestQuery
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Color { get; set; }
    }
    public enum UpdateUserChatColorResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
    }
}
