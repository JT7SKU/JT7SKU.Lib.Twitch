using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class StreamMarkerVideos
    {
        public string VideoId { get; set; }
        public List<VideoMarkers> Markers { get; set; }
    }
}
