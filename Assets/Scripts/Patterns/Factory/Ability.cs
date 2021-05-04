using System;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public abstract class Ability
    {
        public abstract string Name { get; }
        public abstract void Process();
    } 
}