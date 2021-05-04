using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class WaterAbility : Ability
    {
        public override string Name => "Water";
        public override void Process()
        {
            Debug.Log("Player Wet");
        }
    }
}
