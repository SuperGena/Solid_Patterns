using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class KeyboardMovement : MonoBehaviour, IMovementInputGetter
    {
        public float Horizontal { get; private set; }

        public float Vertical { get; private set; }

        private void Update()
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            Vertical = Input.GetAxisRaw("Vertical");
        }
    }
}
