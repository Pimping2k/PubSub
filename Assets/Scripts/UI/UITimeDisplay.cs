using System;
using TMPro;
using UnityEngine;
using Zenject;
using ZenjectPracticing.Configs;

namespace UI
{
    public class UITimeDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text _timeText;
        
        [Inject] private TimeConfig _timeConfig;

        private void Awake()
        {
            _timeText.text = "Time: " + _timeConfig.Time;
        }
    }
}