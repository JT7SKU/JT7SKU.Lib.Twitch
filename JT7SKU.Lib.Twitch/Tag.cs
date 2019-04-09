using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
   public class Tag
    {
        public string Id { get; set; }
        public bool IsAuto { get; set; }
        public List<string> LocalizationNames { get; set; }
        public List<string> LocalizationDescriptions { get; set; }
    }
}
