using JT7SKU.Lib.Twitch;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ServicesKomponentUnit.Data.Twitch
{
    public  class Dashboard
    {
        public int Count { get; set; }
        [Parameter]
        public IEnumerable<Channel> Channels { get; set; }
        //protected override Task OnParametersSetAsync()
        //{
        //    return base.OnParametersSetAsync();
        //}
        //protected override Task OnInitializedAsync()
        //{
        //    Count = Channels.Count();
        //    return base.OnInitializedAsync();
        //}
        Color ChannelStatusToColor(ChannelStatus status)
        {
            return System.Drawing.Color.White;
        }
    }
}
