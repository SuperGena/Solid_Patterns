using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class Human : Race
    {
        internal override string Name => "Human";

        internal override float Strange => 30f;

        public override void Process()
        {
            Debug.Log($"{Name} has created");
        }
    }
}
