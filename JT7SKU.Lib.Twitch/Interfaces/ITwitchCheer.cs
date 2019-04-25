using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Interfaces
{
    public interface ITwitchCheer
    {
        Task NewCheer(Message message);
    }
}
