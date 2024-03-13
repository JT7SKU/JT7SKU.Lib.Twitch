using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class ExtensionViews
    {
        public ExtensionMobile Mobile { get; set; }
        public ExtensionPanel Panel { get; set; }
        public ExtensionVideoOverlay VideoOverlay { get; set; }
        public ExtensionComponent Component { get; set; }
        public ExtensionConfig Config { get; set; }
    }
}
