using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class GlobalCooldown
    {
        public bool IsEnabled { get; set; }
        public int Seconds { get; set; }
    }
}
