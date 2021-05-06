using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class Elf : Race
    {
        internal override string Name => "Elf";

        internal override float Strange => 20f;

        public override void Process()
        {
            Debug.Log($"{Name} has created");
        }
    }
}
