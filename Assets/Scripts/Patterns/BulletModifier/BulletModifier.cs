using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public abstract class BulletModifier : IDamager
    {
        protected IDamager _modifiedDamager;
        protected IDamageable bulletTarget;

        public BulletModifier(IDamager modifiedDamager)
        {
            this._modifiedDamager = modifiedDamager;
        }
        
        public void InflictDamage(IDamageable target)
        {
            if (!_modifiedDamager.Equals(null))
            {
                bulletTarget = target;
                Modify();
            }
        }

        protected abstract void Modify();

        public void AddDamage(int bonusDamage) { }
    }
}
