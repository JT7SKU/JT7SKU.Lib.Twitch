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
        public Color StatusColor { get; set; }
        protected override Task OnParametersSetAsync()
        {
            return base.OnParametersSetAsync();
        }
    }
}
