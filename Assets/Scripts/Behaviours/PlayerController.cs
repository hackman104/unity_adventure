using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RSG;
using RSG.Utils;
using Atalanta.Services;

namespace Atalanta.Behaviours
{
    public class PlayerController : MonoBehaviour
    {
        public float speed;
        [Dependency]
        public RSG.Utils.ILogger Logger { get; set; }
        [Dependency]
        public IInputService InputService { get; set; }
        private Rigidbody2D _rigidBody;

        public void Start()
        {
            App.Instance.Factory.ResolveDependencies(this);
            this._rigidBody = this.GetComponent<Rigidbody2D>();
        }

        public void FixedUpdate()
        {
            float moveHorizontal = this.InputService.getHorizontalAxis();
            float moveVertical = this.InputService.getVerticalAxis();
            var movement = new Vector2(moveHorizontal, moveVertical);
            this._rigidBody.AddForce(movement * speed);
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("PickUp")) {
                other.gameObject.SetActive(false);
            }
        }
    }
}
