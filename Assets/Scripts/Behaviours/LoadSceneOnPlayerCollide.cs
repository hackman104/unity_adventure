using Atalanta;
using Atalanta.Services;
using RSG;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Atalanta.Behaviours
{
    public class LoadSceneOnPlayerCollide : MonoBehaviour
    {
        [Dependency]
        public ISceneLoader SceneLoader { get; set;}
        public string sceneName;

        public void Start()
        {
            App.Instance.Factory.ResolveDependencies(this);
        }

        void OnTriggerEnter2D()
        {
            this.SceneLoader.LoadScene(this.sceneName);
        }
    }
}