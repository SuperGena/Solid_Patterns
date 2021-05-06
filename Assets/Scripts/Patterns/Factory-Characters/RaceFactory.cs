using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Tutorials
{
    public static class RaceFactory
    {
        private static Dictionary<string, Type> raceByName;
        private static bool IsInitialized => raceByName != null;

        public static void InititializeFactory()
        {
            if (IsInitialized)
            {
                return;
            }

            var abilityTypes = Assembly.GetAssembly(typeof(Race))
                .GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Race)));

            raceByName = new Dictionary<string, Type>();

            foreach (var type in abilityTypes)
            {
                var tempEffect = Activator.CreateInstance(type) as Race;
                raceByName.Add(tempEffect.Name, type);
            }
        }

        public static Race GetAbility(string abilityType)
        {
            InititializeFactory();

            if (raceByName.ContainsKey(abilityType))
            {
                Type type = raceByName[abilityType];
                var ability = Activator.CreateInstance(type) as Race;

                return ability;
            }

            return null;
        }

        internal static IEnumerable<string> GetRaceNames()
        {
            UnityEngine.Debug.Log("GetRaceNames");
            InititializeFactory();
            
            return raceByName.Keys;
        }
    }
}
