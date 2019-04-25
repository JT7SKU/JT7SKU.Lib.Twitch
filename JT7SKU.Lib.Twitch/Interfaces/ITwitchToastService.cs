using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Interfaces
{
   public  interface ITwitchToastService 
    {
        Task NewToast(User user,ToastLevel toastLevel, Message message);
        void ShowToast(string message, ToastLevel level);
        
    }
}
