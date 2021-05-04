using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Tutorials
{
    public static class CharacterFactory
    {
        private static Dictionary<string, Type> charctersByName;
        private static bool IsInitialized => charctersByName != null;

        public static void InititializeFactory()
        {
            if (IsInitialized)
            {
                return;
            }

            var abilityTypes = Assembly.GetAssembly(typeof(Ability))
                .GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

            charctersByName = new Dictionary<string, Type>();

            foreach (var type in abilityTypes)
            {
                var tempEffect = Activator.CreateInstance(type) as Ability;
                charctersByName.Add(tempEffect.Name, type);
            }
        }

        public static Ability GetAbility(string abilityType)
        {
            InititializeFactory();

            if (charctersByName.ContainsKey(abilityType))
            {
                Type type = charctersByName[abilityType];
                var ability = Activator.CreateInstance(type) as Ability;

                return ability;
            }

            return null;
        }

        internal static IEnumerable<string> GetAbilityNames()
        {
            UnityEngine.Debug.Log("GetCharctersNames");
            InititializeFactory();
            return charctersByName.Keys;
        }
    }
}
