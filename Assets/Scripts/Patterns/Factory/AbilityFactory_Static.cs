using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Tutorials
{
    public static class AbilityFactory_Static
    {
        private static Dictionary<string, Type> abilitiesByName;
        private static bool IsInitialized => abilitiesByName != null;

        public static void InititializeFactory()
        {
            if (IsInitialized)
                return;

            var abilityTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

            abilitiesByName = new Dictionary<string, Type>();

            foreach (var type in abilityTypes)
            {
                var tempEffect = Activator.CreateInstance(type) as Ability;
                abilitiesByName.Add(tempEffect.Name, type);
            }
        }

        public static Ability GetAbility(string abilityType)
        {
            InititializeFactory();

            if (abilitiesByName.ContainsKey(abilityType))
            {
                Type type = abilitiesByName[abilityType];
                var ability = Activator.CreateInstance(type) as Ability;
                return ability;
            }

            return null;
        }

        internal static IEnumerable<string> GetAbilityNames()
        {
            UnityEngine.Debug.Log("GetAbilityNames");
            InititializeFactory();
            return abilitiesByName.Keys;
        }
    }
}
