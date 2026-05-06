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
        
        [Inject(Id = "FirstTime")] private TimeConfig _timeConfigFirst;
        [Inject(Id = "SecondTime")] private TimeConfig _timeConfigSecond;

        private bool _isFirstConfig;
        
        private void Awake()
        {
            _timeText.text = "First Time: " + _timeConfigFirst.Time;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                _isFirstConfig =  !_isFirstConfig;
                
                if(_isFirstConfig)
                {
                    _timeText.text = "First Time: " + _timeConfigFirst.Time;
                }
                else
                {
                    _timeText.text = "Second Time: " + _timeConfigSecond.Time;
                }
            }
        }
    }
}