using System;
using Events;
using TMPro;
using UnityEngine;

namespace UI
{
    public class UIPlayerStats : MonoBehaviour
    {
        [SerializeField] private TMP_Text _playerHealth;
        [SerializeField] private TMP_Text _playerLastDamage;

        private void Awake()
        {
            Setup();
            PublisherSubscriber.Subscribe<PlayerStatsEvent>(OnStatsReceived);
        }

        private void OnDestroy()
        {
            PublisherSubscriber.Unsubscribe<PlayerStatsEvent>(OnStatsReceived);
        }

        private void OnStatsReceived(PlayerStatsEvent info)
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