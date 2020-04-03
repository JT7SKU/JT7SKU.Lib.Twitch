using JT7SKU.Lib.Twitch;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace ServicesKomponentUnit.Data.Twitch
{
    public partial class ChannelComponent
    {
        [Parameter]
        public string ChannelBoxUrl { get; set; }
        [Parameter]
        public string ChannelName { get; set; }
        [Parameter]
        public ChannelStatus ChannelStatus { get; set; }
        public Color StatusColor { get; set; }
        protected override Task OnParametersSetAsync()
        {
            if (ChannelStatus == ChannelStatus.Online) StatusColor = Color.Green;
            else if (ChannelStatus == ChannelStatus.Offline) StatusColor = Color.Red;
            return base.OnParametersSetAsync();
        }
    }
}
