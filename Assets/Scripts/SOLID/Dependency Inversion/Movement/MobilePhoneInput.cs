using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class MobilePhoneInput : MonoBehaviour, IMovementInputGetter
    {
        public float Horizontal { get; set; }

        public float Vertical { get; set; }

        public float GetHorizontalButtonInput(float input)
        {
            Horizontal = input;
            return input;
        }

        public void SetHorizontalButtonInput(float input)
        {
            GetHorizontalButtonInput(input);
        }
    }
}
