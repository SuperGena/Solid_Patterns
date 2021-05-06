using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public abstract class Race
    {
        internal abstract string Name { get; }
        internal abstract float Strange { get; }
        public abstract void Process();
    }
}
