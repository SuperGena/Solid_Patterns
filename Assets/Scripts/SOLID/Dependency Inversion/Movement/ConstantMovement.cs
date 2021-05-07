using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class ConstantMovement : MonoBehaviour, IMovementInputGetter
    {
        public float Horizontal => 1f;

        public float Vertical => 10f;
    }
}
