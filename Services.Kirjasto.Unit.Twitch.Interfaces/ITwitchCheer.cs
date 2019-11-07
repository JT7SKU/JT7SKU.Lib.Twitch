using JT7SKU.Lib.Twitch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
    public interface ITwitchCheer
    {
        Task NewCheer(Message message);
    }
}
