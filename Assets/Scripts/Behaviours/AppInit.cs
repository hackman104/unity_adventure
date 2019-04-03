using UnityEngine;
using Atalanta;

namespace Atalanta.Behaviours
{
    public class AppInit : MonoBehaviour
    {
        public void Awake()
        {
            Debug.Log("app init starting");
            App.Startup();
            Debug.Log("app init - startup complete");
        }

        void Start()
        {
        }

        void OnApplicationQuit()
        {
            App.Instance.Shutdown();
        }
    }
}