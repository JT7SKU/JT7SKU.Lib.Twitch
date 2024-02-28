using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class Entitlement
    {
        public string OrganizationId { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CampaignId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string EntitlementId { get; set; }
        public string BenefictId { get; set; }
        public string CreatedAt { get; set; }
    }
}
