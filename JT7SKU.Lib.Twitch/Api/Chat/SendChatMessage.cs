using JT7SKU.Lib.Twitch.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class SendChatMessage
    {
        public string SendChatMessageUserBotScope { get; set; } = "user:bot"; // from chatting user
        public string SendChatMessageUserWriteScope { get; set; } = "user:write:chat";
        public string SendChatMessageChannelBotScope { get; set; } = "channel:bot"; // broadcaster or moderator status
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/messages";
        public SendChatMessageRequestBody RequestBody { get; set; }
        public SendChatMessageResponseBody ResponseBody { get; set; }
        public SendChatMessageResponseCodes ResponseCodes { get; set; }
    }
    public record SendChatMessageRequestBody
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string SenderId { get; set; }
        [Required]
        public string Message {  get; set; }
        public string ReplyParentMessageid { get; set; }
    }
    public record SendChatMessageResponseBody
    {
        public SendChatMessageData Data { get; set; }
    }
    public enum SendChatMessageResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        UnprocessableEntity = 422
    }
    public record SendChatMessageData
    {
        public string MessageId { get; set; }
        public bool IsSent { get; set; }
        public ChatMessageDropReason DropReason { get; set; }
    }


}
