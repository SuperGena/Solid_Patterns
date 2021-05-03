using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public interface IStats
    {
        IEnumerable<Stat> GetStats();
    }
}
