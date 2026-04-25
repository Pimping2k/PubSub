using System;
using System.Collections.Generic;

public class SubscriptionList<T> : ISubscriptionList
{
    public readonly List<Action<T>> Handlers = new();
}