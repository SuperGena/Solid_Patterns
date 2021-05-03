using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class BonusDamageModifier : BulletModifier
    {
        [SerializeField] private int _bonusDamage;
        public BonusDamageModifier(IDamager modifiedDamager, int bonusDamage) : base(modifiedDamager)
        {
            this._bonusDamage = bonusDamage;
        }

        protected override void Modify()
        {
            _modifiedDamager.AddDamage(_bonusDamage);
        }
    }
}
