using UnityEngine;

namespace ZenjectPracticing.Global
{
    public class AuthService : MonoBehaviour
    {
        [SerializeField] private string _name = "Andrei";

        public string Name => _name;
    }
}