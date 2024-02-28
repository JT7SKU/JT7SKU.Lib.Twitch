using System.ComponentModel.DataAnnotations;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class Transport
    {
        [Required]
        public string Method { get; set; }
        public string Callback { get; set; }
        public string Secret { get; set; }
        public string SessionId { get; set; }
        public string ConnectedAt { get; set; }
        public string DisconnectedAt { get; set; }
    }
}