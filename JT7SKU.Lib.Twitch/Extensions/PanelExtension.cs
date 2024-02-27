using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch.Extensions
{
    public class PanelExtension
    {
        public string ExtensionID { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public ExtensionType ExtensionType { get; set; } = ExtensionType.Panel;
        public string Version { get; set; }
    }
}
