using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.ChannelPoints
{
    public class CreateCustomRewards
    {
        public string CreateCustomRewardScope { get; set; } = "channel:manage:redemptions";
        public string ClientID { get; set; }
        public string PathUrl { get; set; } = "/channel_points/custom_rewards";
        public CreateCustomRewardRequestQuery RequestQuery { get; set; }
        public CreateCustomRewardRequestBody RequestBody { get; set; }
        public CreateCustomRewardResponseBody ResponseBody { get; set; }
        public CreateCustomRewardResponseCodes ResponseCodes { get; set; }
    }
    public record CreateCustomRewardRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record CreateCustomRewardRequestBody
    {
        [Required, MaxLength(45)]
        public string Title { get; set; }
        [Required]
        public Int64 Cost { get; set; }
    }
    public record CreateCustomRewardResponseBody 
    {
        public CreateCustomRewardData Data { get; set; }
    }
    public record CreateCustomRewardData
    {

    }
    public enum CreateCustomRewardResponseCodes
    {
        OK=200
    }

}
