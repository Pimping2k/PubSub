using Events;
using UnityEngine;

namespace Examples
{
    public class DamageComponent : MonoBehaviour
    {
        [SerializeField] private int _damage;

        public void GiveDamage(string damageResolver = "unknown")
        {
            PublisherSubscriber.Publish(new DamageEvent(_damage,damageResolver));
        }
    }
}