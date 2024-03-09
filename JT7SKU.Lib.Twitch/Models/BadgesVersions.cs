using JT7SKU.Lib.Twitch.EventSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class BadgesVersions
    {
        public string Id { get; set; }
        public Image Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ClickAction { get; set; }
        public string ClickUrl { get; set; }
    }
}
