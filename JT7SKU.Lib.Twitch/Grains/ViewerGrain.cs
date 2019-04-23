using System;
using JT7SKU.Lib.Twitch.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch.Grains
{
    public class ViewerGrain : ITwitchViewer
    {
        public void FollowerAdded(string username)
        {
            throw new NotImplementedException();
        }

        public void FollowerRemoved(string username)
        {
            throw new NotImplementedException();
        }

        public void NewViewer(Message message)
        {
            throw new NotImplementedException();
        }

        public void SubscriptionAdded(string username)
        {
            throw new NotImplementedException();
        }

        public void SubscriptionRemoved(string username)
        {
            throw new NotImplementedException();
        }
    }
}
