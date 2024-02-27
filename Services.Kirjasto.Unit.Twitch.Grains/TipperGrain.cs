using JT7SKU.Lib.Twitch;
using Orleans;
using Services.Kirjasto.Unit.Twitch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Kirjasto.Unit.Twitch.Grains
{
    public class TipperGrain :Grain, ITwitchTip
    {
        public async Task OnActivateAsync()
        {
            await Task.CompletedTask;
        }
        
                   
        public Task NewTip(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
