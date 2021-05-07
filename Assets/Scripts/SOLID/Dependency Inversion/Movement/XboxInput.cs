using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class XboxInput : MonoBehaviour, IMovementInputGetter
    {
        public float Horizontal => throw new System.NotImplementedException();

        public float Vertical => throw new System.NotImplementedException();

        //TODO: Search for Xbox and PS controllers to implement movement
    }
}
