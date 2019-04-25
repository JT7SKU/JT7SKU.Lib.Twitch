using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orleans;

namespace JT7SKU.Lib.Twitch.Interfaces
{
    public interface ITwitchFollower : IGrainWithStringKey
    {
        Task NewFollower(User user,Message message);
    }
}
