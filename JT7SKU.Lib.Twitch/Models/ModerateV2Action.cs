using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.Models
{
    public enum ModerateV2Action
    {
        ban,
        timeout,
        unban,
        untimeout,
        clear,
        emoteonly,
        emoteonlyoff,
        followers,
        followersoff,
        uniquechat,
        uniquechatoff,
        slow,
        slowoff,
        subscribers,
        subscribersoff,
        unraid,
        delete,
        unvip,
        vip,
        raid,
        add_blocked_term,
        add_permitted_term,
        remove_blocked_term,
        remove_permitted_term,
        mod,
        unmod,
        approve_unban_request,
        deny_unban_request,
        warn
    }
}
