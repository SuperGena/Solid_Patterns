using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class HealAbility : Ability
    {
        public override string Name => "Heal";
        public override void Process()
        {
            Debug.Log("Player Healed");
        }
    }
}
