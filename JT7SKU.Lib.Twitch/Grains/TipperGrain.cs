using JT7SKU.Lib.Twitch.Interfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Grains
{
    public class TipperGrain :Grain, ITwitchTip
    {
        public override Task OnActivateAsync()
        {
            return base.OnActivateAsync();
        }
        
                   
        public Task NewTip(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
