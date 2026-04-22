using Events;
using UnityEngine;

namespace Examples
{
    public class DamageComponent : MonoBehaviour
    {
        [SerializeField] private Vector2 _damage;

        public float LastAppliedDamage { get; private set; } = 0;
        
        public void GiveDamage(HealthComponent healthComponent)
        {
            LastAppliedDamage = Random.Range(_damage.x, _damage.y);
            healthComponent.ChangeHealth(-LastAppliedDamage);
        }
    }
}