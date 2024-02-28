using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events
{
    public class DropEntitlementGrantEvent
    {
        public string Id { get; set; }
        public Entitlement Data { get; set; }
    }
}
