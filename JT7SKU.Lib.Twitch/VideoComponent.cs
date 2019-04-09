using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    public class VideoComponent
    {
        public string ExtensionID { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public ExtensionType ExtensionType { get; set; } = ExtensionType.Component;
        public string Version { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
