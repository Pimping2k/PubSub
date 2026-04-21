using System;
using System.Collections.Generic;
using UnityEngine;

public class PublisherSubscriber
{
    private static readonly Dictionary<Type, List<object>> _subscribers = new();

    public static void Subscribe<T>(object subscriber) where T : struct
    { 
        if (!_subscribers.ContainsKey(typeof(T)))
        {
            _subscribers[typeof(T)] = new List<object>();
        }
        
        _subscribers[typeof(T)].Add(subscriber);
    }

    public static void Unsubscribe<T>(object subscriber) where T : struct
    {
        if(!_subscribers.ContainsKey(typeof(T)))
        {
            Debug.Log("Don't subscribed " + typeof(T).FullName);
            return;
        }
        
        _subscribers[typeof(T)].Remove(subscriber);
    }

    public static void Publish<T>(T info) where T : struct
    {
        if (!_subscribers.ContainsKey(typeof(T)))
        {
            Debug.Log("Dont have this subscriber " + typeof(T).FullName);
            return;
        }
        
        if(_subscribers.TryGetValue(typeof(T), out List<object> subscribers))
        {
            for (int i = 0; i < subscribers.Count; i++)
            {
                ((IEvent<T>)subscribers[i]).Publish(info);
            }
        }
    }
}