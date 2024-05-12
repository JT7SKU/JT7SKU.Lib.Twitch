using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Automod
{
    public class AutomodSettingsUpdateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public string ModeratorUserId { get; set; }
        public string ModeratorUserName { get; set; }
        public string ModeratorUserLogin { get; set; }
        public int OverallLevel { get; set; }
        public int Disability { get; set; }
        public int Aggression { get; set; }
        public int SexualitySexorGender { get; set; }
        public int Misogyny { get; set; }
        public int Bullying { get; set; }
        public int Swearing { get; set; }
        public int RaceEthnicityOrReligion { get; set; }
        public int SexBasedTherms { get; set; }
    }
}
