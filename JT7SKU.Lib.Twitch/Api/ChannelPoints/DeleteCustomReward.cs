using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.ChannelPoints
{
    public class DeleteCustomReward
    {
        public string DeleteCustomRewardScope { get; set; } = "channel:manage:redemptions";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channel_points/custom_rewards";
        public DeleteCustomRewardRequestQuery RequestQuery { get; set; }
        public DeleteCustomRecordResponseCodes ResponseCodes { get; set; }
    }
    public record DeleteCustomRewardRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string Id { get; set; }
    }
    public enum DeleteCustomRecordResponseCodes
    {
        NoContent=204,
        BadRequest=400,
        Unauthorized=401,
        Forbidden=403,
        NotFound=404,
        InternalServerError=500
    }
}
