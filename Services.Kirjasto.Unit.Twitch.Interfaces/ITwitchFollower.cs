﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch;
using Orleans;

namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
    public interface ITwitchFollower : IGrainWithStringKey
    {
        Task NewFollower(User user,Message message);
    }
}
