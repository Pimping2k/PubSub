using System;
using Events;
using TMPro;
using UnityEngine;

namespace UI
{
    public class UIPlayerStats : MonoBehaviour, IEvent<PlayerStatsEvent>
    {
        [SerializeField] private TMP_Text _playerHealth;
        [SerializeField] private TMP_Text _playerLastDamage;

        private void Awake()
        {
            Setup();
        }

        private void OnEnable()
        {
            PublisherSubscriber.Subscribe<PlayerStatsEvent>(this);
        }

        private void OnDisable()
        {
            PublisherSubscriber.Unsubscribe<PlayerStatsEvent>(this);
        }

        public void Publish(PlayerStatsEvent info)
        {
            Debug.Log($"UI Received: HP {info.Health}, Damage {info.LastDamage}");
            _playerHealth.text = info.Health.ToString();
            _playerLastDamage.text = info.LastDamage.ToString();
        }

        private void Setup()
        {
            _playerHealth.text = "___";
            _playerLastDamage.text = "0";
        }
    }
}