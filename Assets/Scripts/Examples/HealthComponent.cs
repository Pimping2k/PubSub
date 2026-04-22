using System;
using UnityEngine;

namespace Examples
{
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private float _maxHealth = 100f;
        
        public float Health { get; private set; }
        
        public event Action<float> HealthChanged;

        private void Awake()
        {
            Health = _maxHealth;
        }

        public void ChangeHealth(float health)
        {
            Health = Mathf.Clamp(health + Health, 0, _maxHealth);
            HealthChanged?.Invoke(Health);
        }
    }
}