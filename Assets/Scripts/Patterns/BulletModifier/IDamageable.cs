using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public interface IDamageable
    {
        void ReceiveDamage(int damage);
        void ReceiveDamageOverTime(int damage, int daration);
    }
}
