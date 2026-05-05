using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ZenjectPracticing.Local
{
    public class LocalSceneService : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                SceneManager.LoadScene("AdditiveScene", LoadSceneMode.Additive);
            }
        }
    }
}