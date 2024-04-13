using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public  class ScheduleSegment
    {
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Title { get; set; }
        public DateTime CanceletUntil { get; set; }
        public StreamCategory Category { get; set; }
        public bool IsRecurring { get; set; }
    }
}
