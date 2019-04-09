using System;
using System.Collections.Generic;

namespace JT7SKU.Lib.Twitch
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; } // Login name
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string OfflineImageUrl { get; set; }
        public string ProfileImageUrl { get; set; }
        public List<UserStatus> UserType { get; set; }


    }
}
