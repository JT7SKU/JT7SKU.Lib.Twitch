using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Stream
{
    public class StreamOnlineCondition
    {
        [Required]
        public string BroadcasterUserId { get; set; }
    }
}
