using UnityEngine;
using ZenjectPracticing.Interfaces;

namespace ZenjectPracticing.Local
{
    public class ServiceSecond : MonoBehaviour, IGeneralService
    {
        public string Name { get; set; }  = "Second Service";
    }
}