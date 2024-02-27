namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChatMessage
    {
        public string Text { get; set; }
        public ChatMessageFragments Fragments { get; set; }
    }
}