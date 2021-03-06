using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class Hobbit : Race
    {
        internal override string Name => "Hobbit";

        internal override float Strange => 80f;

        public override void Process()
        {
            Debug.Log($"{Name} has created");
        }
    }
}
