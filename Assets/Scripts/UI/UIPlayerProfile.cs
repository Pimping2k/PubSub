using System;
using TMPro;
using UnityEngine;
using Zenject;
using ZenjectPracticing.Global;

namespace UI
{
    public class UIPlayerProfile : MonoBehaviour
    {
        [SerializeField] private TMP_Text _playerName;
        
        private AuthService _authService;
        
        [Inject]
        public void Construct(AuthService authService)
        {
            _authService = authService;
        }

        private void Start()
        {
            Debug.Log($"UIPlayerProfile player name :  {_authService.Name}");
            _playerName.text = _authService.Name;
        }

        private void Awake()
        {
            _authService.NameChanged += OnNameChanged;
        }

        private void OnNameChanged()
        {
            _playerName.text = _authService.Name;
        }
    }
}