using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class Choices
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int BitVotes { get; set; } = 0;
        public int ChannelPointsVotes { get; set; }
        public int Votes { get; set; }
    }
}
