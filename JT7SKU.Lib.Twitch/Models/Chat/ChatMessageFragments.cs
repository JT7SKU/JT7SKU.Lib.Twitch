using System.ComponentModel.Design;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Emojis;

namespace JT7SKU.Lib.Twitch.Models
{
    public class ChatMessageFragments
    {
        public string Type { get; set; }
        public string Text { get; set; }
        public CheerMote CheerMote { get; set; }
        public Emote Emote { get; set; }
        public Mention Mention { get; set; }
    }
}