using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Conditions
{
    public class UserUpdateCondition
    {
        [Required]
        public string UserId { get; set; }
    }
}
