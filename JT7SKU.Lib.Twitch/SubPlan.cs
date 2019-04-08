using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch
{
    public class SubPlan
    {
        public int Id { get; set; }
        public SubPlanType GetSubPlanType { get; set; }
        public string PlanName { get; set; }
    }
}
