using UnityEngine;

namespace ZenjectPracticing.Configs
{
    [CreateAssetMenu(fileName = "TimeConfig", menuName = "ZenjectPracticing/Configs/Time")]
    public class TimeConfig : ScriptableObject
    {
        [SerializeField] private int _time;
        
        public int Time => _time;
    }
}