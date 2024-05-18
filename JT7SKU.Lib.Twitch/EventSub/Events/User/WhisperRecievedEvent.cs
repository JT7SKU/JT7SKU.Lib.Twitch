using JT7SKU.StreamService.KirjastoUtility.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.User
{
    public class WhisperRecievedEvent
    {
        public string FromUserId { get; set; }
        public string FromUserName { get; set; }
        public string FromUserLogin { get; set; }
        public string ToUserId { get; set; }
        public string ToUserName { get; set; }
        public string ToUserLogin { get; set; }
        public string WhisperId { get; set; }
        public WhisperMessage Whisper {  get; set; }
    }
}
