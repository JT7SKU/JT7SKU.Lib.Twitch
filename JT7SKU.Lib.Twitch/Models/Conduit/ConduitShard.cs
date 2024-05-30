using JT7SKU.Lib.Twitch.EventSub;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Conduit
{
    public class ConduitShard
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
}
