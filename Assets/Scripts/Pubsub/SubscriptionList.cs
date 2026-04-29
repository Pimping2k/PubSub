using System;
using System.Collections.Generic;

namespace Pubsub
{
    public class SubscriptionList<T> : ISubscriptionList
    {
        public readonly List<Action<T>> Handlers = new();
    }
}