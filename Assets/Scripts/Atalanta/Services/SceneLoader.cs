using RSG;
using UnityEngine.SceneManagement;

namespace Atalanta.Services
{
    [Singleton(typeof(ISceneLoader))]
    public class SceneLoader : ISceneLoader
    {
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}