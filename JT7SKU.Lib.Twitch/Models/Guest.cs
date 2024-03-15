namespace JT7SKU.Lib.Twitch.Models
{
    public class Guest
    {
        public string SlotId { get; set; }
        public bool IsLive { get; set; }
        public string UserId { get; set; }
        public string UserDispayName { get; set; }
        public string UserLogin {  get; set; }
        public int Volume { get; set; }
        public MediaSettings AudioSettings { get; set; }
        public MediaSettings VideoSettings { get; set;
    }
}