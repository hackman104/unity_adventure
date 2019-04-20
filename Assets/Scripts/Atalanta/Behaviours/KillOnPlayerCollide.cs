using UnityEngine;

namespace Atalanta.Behaviours
{
    public class KillOnPlayerCollide : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                var audioSource = this.GetComponent<AudioSource>();
                audioSource.Play();

                // not extreeeemely confident about this but it's the best i could think of.
                // we can't disable/destroy this object immediately, because it'll stop
                // the audio source from playing. so we disable the renderer and collider
                // and schedule the object for destruction
                Debug.Log("got the audio source " + audioSource.clip.length);
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<Collider2D>().enabled = false;
                Destroy(this, audioSource.clip.length);
            }
        }
    }
}