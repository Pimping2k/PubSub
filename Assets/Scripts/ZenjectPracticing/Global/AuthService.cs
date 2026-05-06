using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ZenjectPracticing.Global
{
    public class AuthService : MonoBehaviour
    {
        [SerializeField] private string _name = "Andrei";

        public string Name => _name;

        public event Action NameChanged;
        
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.K))
            {
                _name = "Andrei " + Random.Range(1, 22);
                NameChanged?.Invoke();
            }
        }
    }
}