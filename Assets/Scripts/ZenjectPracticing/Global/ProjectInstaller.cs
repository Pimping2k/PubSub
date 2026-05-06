using UnityEngine;
using Zenject;
using ZenjectPracticing.Configs;
using ZenjectPracticing.Interfaces;
using ZenjectPracticing.Local;

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
        [SerializeField] private TimeConfig _timeConfigFirst;
        [SerializeField] private TimeConfig _timeConfigSecond;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<AuthService>().FromComponentInNewPrefab(_authService).AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<InputService>().FromComponentInNewPrefab(_inputService).AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<PlayerCreateService>().FromComponentInNewPrefab(_playerCreateService).AsSingle().NonLazy();
            
            Container.Bind<IGeneralService>().To<ServiceFirst>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            Container.Bind<IGeneralService>().To<ServiceSecond>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
            
            Container.BindInstance(_timeConfigFirst).WithId("FirstTime");
            Container.BindInstance(_timeConfigSecond).WithId("SecondTime");
            Container.BindInstance(_gameSettings).AsSingle();
        }
    }
}