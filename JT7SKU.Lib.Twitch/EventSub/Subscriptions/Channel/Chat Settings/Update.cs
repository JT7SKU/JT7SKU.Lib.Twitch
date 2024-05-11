using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Chat;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Chat_Settings
{
    internal class Update
    {
    }
    #region Channel.Chat Settings.Update
    //
    public record ChannelChatSettingsRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelChatSettingsUpdateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelChatSettingsNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelChatSettingsUpdateEvent Event { get; set; }
    }
    #endregion
}
