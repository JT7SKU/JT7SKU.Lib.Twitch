using JT7SKU.StreamService.KirjastoUtility.Twitch.Utils;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.Bots
{
    internal class KeskusteluBotti
    {
        public string BotName { get; set; }
        public BotRatelimit BotRateLimit { get; set; }
        public List<string> Kommands { get; set; }
        public string Membership { get; set; }
        public List<string> Tags {  get; set; } 
    }
}
