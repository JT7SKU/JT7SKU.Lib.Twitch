using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Conditions
{
    public class DropEntitlementGrantCondition
    {
        [Required]
        public string OrganizationId { get; set; }
        public string CategoryId { get; set; }
        public string CampaignId { get; set; }
    }
}
