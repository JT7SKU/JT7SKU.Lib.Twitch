using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Moderation
{
    public class ModerateTimeOut
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string Reason { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
