using System;
using System.Collections.Generic;
using System.Text;
using Orleans;

namespace JT7SKU.Lib.Twitch.Interfaces
{
    public interface ITwitchSubscriber :IGrainWithStringKey
    {
        void NewSubscriber(Message message);
    }
}
