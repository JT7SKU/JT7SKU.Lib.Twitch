using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class Conduit
    {
        public string ConduitId { get; set; }
        public string Shard { get; set; }
        public int ShardsCount { get; set; }
    }
}
