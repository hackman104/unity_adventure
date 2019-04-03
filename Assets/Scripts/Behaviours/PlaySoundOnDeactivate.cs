using UnityEngine;

namespace Atalanta.Behaviours
{
    public class PlaySoundOnDeactivate : MonoBehaviour
    {
        void OnDisable()
        {
            var audioSource = this.GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
}