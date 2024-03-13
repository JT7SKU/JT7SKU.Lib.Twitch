using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class ExtensionComponent
    {
        public string ViewerUrl {  get; set; }
        public int AspectRatioX { get; set; }
        public int AspectRatioY { get; set; }
        public bool Autoscale { get; set; }
        public int ScalePixels { get; set; }
        public int TargetHeight { get; set; }
        public bool CanLinkExternalContent { get; set; }
    }
}
