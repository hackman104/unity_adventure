using Atalanta;
using Atalanta.Services;
using RSG;
using UnityEngine;

namespace Atalanta.Behaviours
{
    public class LoadSceneOnClick : MonoBehaviour
    {
        public string sceneName;

        [Dependency]
        public ISceneLoader SceneLoader { get; set; }

        public void Start()
        {
            App.Instance.Factory.ResolveDependencies(this);
        }

        public void LoadScene()
        {
            this.SceneLoader.LoadScene(this.sceneName);
        }
    }
}