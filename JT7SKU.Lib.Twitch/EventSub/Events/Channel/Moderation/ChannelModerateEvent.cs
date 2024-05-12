using JT7SKU.Lib.Twitch.Api.Channels;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models.Moderation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Moderation
{
    public class ChannelModerateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string ModeratorUserId { get; set; }
        public string ModeratorUserName { get; set; }
        public string ModeratorUserLogin { get; set; }
        public ModerateAction Action { get; set; }
        public ModerateFollowers Followers { get; set; }
        public ModerateSlow Slow { get; set; }
        public ModerateVip Vip { get; set; }
        public ModerateUnVip UnVip { get; set; }
        public ModerateMod Mod {  get; set; }
        public ModerateUnMod UnMod { get; set; }
        public ModerateBan Ban { get; set; }
        public ModerateUnban Unban { get; set; }
        public ModerateTimeOut TimeOut { get; set; }
        public ModerateUnTimeout UnTimeout { get; set; }
        public ModerateRaid Raid { get; set; }
        public ModerateUnRaid UnRaid { get; set; }
        public ModerateDelete Delete { get; set; }
        public ModerateAutomodTerms AutomodTerms { get; set; }
        public ModerateUnbanRequest UnbanRequest { get; set; }

    }
}
