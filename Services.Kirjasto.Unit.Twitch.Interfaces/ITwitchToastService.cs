using JT7SKU.Lib.Twitch;
using Orleans.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
   public  interface ITwitchToastService : IGrainService
    {
        Task NewToast(User user,ToastLevel toastLevel, Message message);
        void ShowToast(string message, ToastLevel level);
        
    }
}
