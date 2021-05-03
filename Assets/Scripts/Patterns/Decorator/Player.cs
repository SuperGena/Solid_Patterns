using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class Player : MonoBehaviour, IStats
    {
        public IEnumerable<Stat> GetStats()
        {
            throw new System.NotImplementedException();
        }
        
    }
}
