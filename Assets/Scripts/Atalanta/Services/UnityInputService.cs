using RSG;
using UnityEngine;

namespace Atalanta.Services
{
    [Singleton(typeof(IInputService))]
    public class UnityInputService: IInputService
    {
        public float getHorizontalAxis()
        {
            return Input.GetAxis("Horizontal");
        }

        public float getVerticalAxis()
        {
            return Input.GetAxis("Vertical");
        }
    }
}