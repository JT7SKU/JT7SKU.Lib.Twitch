using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class ExtensionSecret
    {
        public string Content { get; set; }
        public DateTime ActiveAt { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
