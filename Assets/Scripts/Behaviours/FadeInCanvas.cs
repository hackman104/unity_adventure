using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Atalanta.Behaviours
{
    public class FadeInCanvas : MonoBehaviour
    {
        private CanvasRenderer _renderer;

        public void Start()
        {
            this._renderer = this.gameObject.GetComponent<CanvasRenderer>();
        }

        public void Update()
        {

        }
    }

}