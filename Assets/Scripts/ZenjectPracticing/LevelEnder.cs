using UnityEngine;
using Zenject;

namespace ZenjectPracticing
{
    public class LevelEnder : MonoBehaviour
    {
        [Inject] private ZenjectSceneLoader _sceneLoader;
        
        public void FinisheLevel()
        {
        }
    }
}