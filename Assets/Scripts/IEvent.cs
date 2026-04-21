using UnityEngine;

public interface IEvent<T> where T : struct
{
    void Publish(T info);
}
