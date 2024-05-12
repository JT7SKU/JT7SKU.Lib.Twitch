using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Moderation
{
    public class ModerateAutomodTerms
    {
        public string Action { get; set; }
        public string List { get; set; }
        public string[] Terms { get; set; }
        public bool FromAutomod { get; set; }
    }
}
