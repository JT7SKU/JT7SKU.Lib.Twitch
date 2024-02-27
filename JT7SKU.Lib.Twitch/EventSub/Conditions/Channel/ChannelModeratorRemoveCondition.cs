using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Conditions.Channel
{
    public class ChannelModeratorRemoveCondition
    {
        [Required]
        public string BroadcasterUserID { get; set; }
    }
}
