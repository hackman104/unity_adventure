using UnityEngine;
using UnityEngine.SceneManagement;

namespace Atalanta.Behaviours
{
    public class LevelSwitch : MonoBehaviour
    {
        public string sceneName;

        void OnTriggerEnter2D()
        {
            SceneManager.LoadScene(this.sceneName);
        }
    }
}