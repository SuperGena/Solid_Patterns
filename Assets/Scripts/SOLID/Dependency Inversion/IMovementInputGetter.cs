using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public interface IMovementInputGetter
    {
        float Horizontal { get; }
        float Vertical { get; }
    }
}
