using System;
using JT7SKU.Lib.Twitch;
using System.Collections.Generic;
using System.Text;
using Orleans;
using System.Threading.Tasks;
using Services.Kirjasto.Unit.Twitch.Interfaces;
using System.Threading;

namespace Services.Kirjasto.Unit.Twitch.Grains
{
    public class ViewerGrain : Grain,ITwitchViewer
    {
        public override async Task OnActivateAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
        public void FollowerAdded(string username)
        {
            throw new NotImplementedException();
        }

        public void FollowerRemoved(string username)
        {
            throw new NotImplementedException();
        }

        public void NewViewer(Message message)
        {
            throw new NotImplementedException();
        }

        public void SubscriptionAdded(string username)
        {
            throw new NotImplementedException();
        }

        public void SubscriptionRemoved(string username)
        {
            throw new NotImplementedException();
        }
    }
}
