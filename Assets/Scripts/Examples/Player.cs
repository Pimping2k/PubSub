using System;
using Events;
using UnityEngine;

namespace Examples
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private DamageComponent _damageComponent;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _damageComponent.GiveDamage("Andryuha");
            }
        }
    }
}