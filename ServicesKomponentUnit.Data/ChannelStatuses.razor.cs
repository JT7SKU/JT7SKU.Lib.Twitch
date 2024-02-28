using JT7SKU.Lib.Twitch.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesKomponentUnit.Data.Twitch
{
    public partial class ChannelStatuses
    {
        private HubConnection Hub;
        [Inject]
        public NavigationManager NavnManager { get; set; }
       
        public int Count { get; set; }
        [Parameter]
        public List<Channel> Channels { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Hub = new HubConnectionBuilder()
                .WithUrl(NavnManager.ToAbsoluteUri("/api"))
                .WithAutomaticReconnect()
                .Build();
            Hub.On<Channel>("StatusChanged", message =>
             {
                 Channels.Add(message);
                 StateHasChanged();
                 
             });
            await Hub.StartAsync();
            Count = Channels.Count();
            
        }
    }
}
