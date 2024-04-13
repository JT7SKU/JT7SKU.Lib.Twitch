using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class VideoMarkers
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int PositionSeconds { get; set; }
        public string Url { get; set; } // url opens to twitch higlighter
    }
}
