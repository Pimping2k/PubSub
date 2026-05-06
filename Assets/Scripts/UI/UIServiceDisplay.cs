using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using Zenject;
using ZenjectPracticing.Interfaces;
using ZenjectPracticing.Local;

namespace UI
{
    public class UIServiceDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text _firstServiceName;
        [SerializeField] private TMP_Text _secondServiceName;
        
        private IGeneralService _firstService;
        private IGeneralService _secondService;
        
        [Inject]
        public void Construct(List<IGeneralService> services)
        { 
            _firstService = services.FirstOrDefault(s => s is ServiceFirst);
            _secondService = services.FirstOrDefault(s => s is ServiceSecond);
        }

        private void Start()
        {
            _firstServiceName.text = _firstService.Name;
            _secondServiceName.text = _secondService.Name;
        }
    }
}