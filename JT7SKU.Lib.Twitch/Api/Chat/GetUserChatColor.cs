using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class GetUserChatColor
    {
        // Authorization Requires App Access Token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/color";
        public GetUserChatColorRequestQuery RequestQuery { get; set; }
        public GetUserChatColorResponseBody ResponseBody { get; set; }
        public GetUserChatColorResponseCodes ResponseCodes { get; set; }
    }
    public record GetUserChatColorRequestQuery
    {
        [Required]
        public string UserId { get; set; } // max user IDs to set is 100
    }
    public record GetUserChatColorResponseBody
    {
        public GetUserChatColorData Data { get; set; }
    }
    public enum GetUserChatColorResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetUserChatColorData
    {
        public string UserId { get; set;}
        public string UserLogin { get; set;}
        public string UserName { get; set;}
        public string Color { get; set;} // hex color code
    }
}
