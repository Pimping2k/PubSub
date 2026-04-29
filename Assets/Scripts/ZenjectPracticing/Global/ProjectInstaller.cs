using UnityEngine;
using Zenject;
using ZenjectPracticing.Configs;

namespace ZenjectPracticing.Global
{
    public class ProjectInstaller : MonoInstaller
    {
        [Header("Services")]
        [SerializeField] private AuthService _authService;
        [SerializeField] private InputService _inputService;
        [SerializeField] private PlayerCreateService _playerCreateService;
        [Header("Configs")]
        [SerializeField] private GameSettings _gameSettings;
        [SerializeField] private TimeConfig _timeConfig;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<AuthService>().FromComponentInNewPrefab(_authService).AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<InputService>().FromComponentInNewPrefab(_inputService).AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<PlayerCreateService>().FromComponentInNewPrefab(_playerCreateService).AsSingle().NonLazy();
            
            Container.BindInstance(_timeConfig).AsSingle();
            Container.BindInstance(_gameSettings).AsSingle();
        }
    }
}