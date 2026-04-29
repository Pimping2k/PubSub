using UnityEngine;
using Zenject;
using ZenjectPracticing.Configs;
using ZenjectPracticing.Global;

namespace ZenjectPracticing.Local
{
    public class SceneInstaller : MonoInstaller
    {
        [SerializeField] private LocalSceneService _localSceneService;
        
        public override void InstallBindings()
        {
            Container.Bind<LocalSceneService>().FromComponentInNewPrefab(_localSceneService).AsSingle().NonLazy();
            Container.Bind<PlayerService>().AsSingle().NonLazy();
        }
    }
}