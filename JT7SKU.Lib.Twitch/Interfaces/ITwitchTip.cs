using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Interfaces
{
    public interface ITwitchTip
    {
        Task NewTip(Message message);
    }
}
