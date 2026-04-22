using System;
using Events;
using UnityEngine;

namespace Examples
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private DamageComponent _damageComponent;
        [SerializeField] private HealthComponent _healthComponent;

        private void Awake()
        {
            _healthComponent.HealthChanged += OnHealthChanged;
        }

        private void OnDestroy()
        {
            _healthComponent.HealthChanged -= OnHealthChanged;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _damageComponent.GiveDamage(_healthComponent);
            }
        }

        private void OnHealthChanged(float health)
        {
            PublisherSubscriber.Publish(new PlayerStatsEvent(_damageComponent.LastAppliedDamage, _healthComponent.Health));
        }
    }
}