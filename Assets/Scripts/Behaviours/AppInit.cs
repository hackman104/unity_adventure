using UnityEngine;
using Atalanta;

namespace Atalanta.Behaviours
{
    public class AppInit : MonoBehaviour
    {
        public void Awake()
        {
            App.Startup();
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