using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    [Serializable]
    public class ProfileState
    {
        public User User { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}
