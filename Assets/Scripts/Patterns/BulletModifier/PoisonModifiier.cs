using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class PoisonModifiier : BulletModifier
    {
        int _poisonDamage;
        int _poisonDuraition;

        public PoisonModifiier(IDamager modifiedDamager, int poisonDamage, int poisonDuration) : base(modifiedDamager)
        {
            this._poisonDamage = poisonDamage;
            this._poisonDuraition = poisonDuration;
        }

        protected override void Modify()
        {
            bulletTarget.ReceiveDamageOverTime(_poisonDamage, _poisonDuraition);
        }
        
    }
}
