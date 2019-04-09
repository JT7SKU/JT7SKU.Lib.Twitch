using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    public class Extension
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool CanActivate { get; set; }
        public List<ExtensionType> ExtensionTypes { get; set; }
        public string Version { get; set; }
    }
}
