using UnityEngine;
using Atalanta;

namespace Atalanta.Behaviours
{
    public class AppInit : MonoBehaviour
    {
        public void Awake()
        {
            App.Startup();
            Debug.Log("startup complete");
        }

        public void OnApplicationQuit()
        {
            App.Instance.Shutdown();
        }
    }
}