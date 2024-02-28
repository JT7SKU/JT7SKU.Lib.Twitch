using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Bits { get; set; }
        public string Sku { get; set; }
        public bool IsDevelopment { get; set; }
    }
}
