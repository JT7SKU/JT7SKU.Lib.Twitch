using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Emojis;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class SubMessage
    {
        public string Text { get; set; }
        public Emotes Emotes { get; set; }
    }
}
