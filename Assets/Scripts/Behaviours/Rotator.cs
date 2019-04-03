using UnityEngine;

namespace Atalanta.Behaviours
{
    public class Rotator : MonoBehaviour
    {
        void Update()
        {
            this.transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
        }
    }

}