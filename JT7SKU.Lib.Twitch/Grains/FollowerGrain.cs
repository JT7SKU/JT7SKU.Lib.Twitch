using JT7SKU.Lib.Twitch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Grains
{
    public class FollowerGrain : ITwitchFollower
    {
        private readonly Follower follower;
        private bool IsFollowing = false;
        public Task NewFollower(User user,Message message)
        {
            follower.User = user;
            IsFollowing = true;
            return Task.CompletedTask;
        }
    }
}
