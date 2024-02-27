namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChatReply
    {
        public string ParentMessageId { get; set; }
        public string ParentMessageBody { get; set; }
        public string ParentUserId { get; set; }
        public string ParentUserName { get; set; }
        public string ParentUserLogin { get; set; }
        public string ThreadUserId { get; set; }
        public string ThreadUserName { get; set; }
        public string ThreadUserLogin { get; set; }
    }
}