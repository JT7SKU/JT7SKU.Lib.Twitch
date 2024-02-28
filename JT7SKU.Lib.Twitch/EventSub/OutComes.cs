using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class OutComes
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public int Users { get; set; }
        public int ChannelPoints { get; set; }
        public TopPredictors TopPredictors { get; set; }
    }
}
