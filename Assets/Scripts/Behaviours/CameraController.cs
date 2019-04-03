using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Atalanta.Behaviours
{
    public class CameraController : MonoBehaviour
    {
        public GameObject player;
        private Vector3 _offset;

        void Start()
        {
            this._offset = this.transform.position - this.player.transform.position;
        }

        // runs every frame, but after update (so player movement will have completed)
        void LateUpdate()
        {
            this.transform.position = this.player.transform.position + _offset;
        }
    }

}