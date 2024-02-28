using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events
{
    public class GoalsEvent
    {
        public string Id { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public GoalType Type { get; set; }
        public string Description { get; set; }
        public bool IsAchieved { get; set; }
        public int CurrentAmount { get; set; }
        public int TargetAmount { get; set; }
        public string StartedAt { get; set; }
        public string EndedAt { get; set; }
    }
}
