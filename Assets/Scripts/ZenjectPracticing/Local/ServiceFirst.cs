using UnityEngine;
using ZenjectPracticing.Interfaces;

namespace ZenjectPracticing.Local
{
    public class ServiceFirst : MonoBehaviour, IGeneralService
    {
        public string Name { get; set; } = "First Service";
    }
}