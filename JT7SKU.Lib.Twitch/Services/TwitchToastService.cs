using JT7SKU.Lib.Twitch.Grains;
using JT7SKU.Lib.Twitch.Interfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Concurrency;
using Orleans.Core;
using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace JT7SKU.Lib.Twitch.Services
{
    // Service alert channel what broadcast
    [Reentrant]
    public class TwitchToastService : GrainService, ITwitchToastService , IDisposable
    {
        readonly IGrainFactory GrainFactory;
        private SubscriberGrain subscriberGrain;
        private FollowerGrain followerGrain;
        private TipperGrain tipperGrain;
        private CheererGrain cheererGrain;
        private Timer Countdown;
        public event Action OnHide;
        public event Action<string, ToastLevel> OnShow;
        public TwitchToastService(IServiceProvider services, IGrainIdentity id, Silo silo, ILoggerFactory LoggerFactory, IGrainFactory grainFactory) : base(id, silo, LoggerFactory) => GrainFactory = grainFactory;
        public override Task Init(IServiceProvider serviceProvider)
        {
            return base.Init(serviceProvider);
        }
        public override Task Stop()
        {
            return base.Stop();
        }
        public override Task Start()
        {
            return base.Start();
        }
        public async Task NewToast(User user,ToastLevel toastLevel,Message message)
        {
            switch (toastLevel)
            {
                case ToastLevel.NewCheer:
                  await cheererGrain.NewCheer(message);
                    break;
                case ToastLevel.NewFollower:
                    await followerGrain.NewFollower(user,message);
                    break;
                case ToastLevel.NewSubscriber:
                    await subscriberGrain.NewSubscriber(user, message);
                    break;
                case ToastLevel.NewTip:
                    await tipperGrain.NewTip(message);
                    break;
            }
        }

        public void Dispose()
        {
            Countdown?.Dispose();
        }

        public void ShowToast(string message, ToastLevel level)
        {
            OnShow?.Invoke(message, level);
            StartCountdown();
        }

        private void StartCountdown()
        {
            SetCowndown();
            if (Countdown.Enabled)
            {
                Countdown.Stop();
                Countdown.Start();
            }
            else
            {
                Countdown.Start();
            }
        }

        private void HideToast(object source, ElapsedEventArgs args)
        {
            OnHide?.Invoke();
        }

        private void SetCowndown()
        {
            if (Countdown == null)
            {
                Countdown = new Timer(5000);
                Countdown.Elapsed += HideToast;
                Countdown.AutoReset = false;
            }
        }
    }
}
