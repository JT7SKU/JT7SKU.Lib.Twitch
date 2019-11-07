using System;
using System.Collections.Generic;
using System.Text;
using JT7SKU.Lib.Twitch;
using Orleans;

namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
    public interface ITwitchViewer : IGrainObserver
    {
        void NewViewer(Message message);
        void SubscriptionAdded(string username);
        void SubscriptionRemoved(string username);
        void FollowerAdded(string username);
        void FollowerRemoved(string username);
    }
}
