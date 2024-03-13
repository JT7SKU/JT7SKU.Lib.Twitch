using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Extensions
{
    public class SendExtensionPubSubMessage
    {
        // JWT auth The signed JWT must include the role, user_id, and exp fields along with the channel_id and pubsub_perms fields. The role field must be set to external
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/extensions/pubsub";
        public SendExtensionPubSubMessageRequestBody RequestBody { get; set; }
        public SendExtensionPubSubMessageResponseCodes ResponseCodes { get; set; }
    }
    public record SendExtensionPubSubMessageRequestBody
    {
        [Required]
        public PubSubTargetType Target {  get; set; } // wisper_user_id is whisper-<user-id>
        [Required]
        public string BroadcasterId { get; set; }
        public bool IsGlobalBroadcast { get; set; }
        [Required]
        public string Message { get; set; }
    }
    public enum SendExtensionPubSubMessageResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        UnprocessableEntity = 422
    }
}
