using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public interface IDamager
    {
        void InflictDamage(IDamageable target);
        void AddDamage(int bonusDamage);
    }
}
