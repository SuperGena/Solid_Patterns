using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class ButtonPanel : MonoBehaviour
    {
        [SerializeField] private AbilityButton buttonPrefab;

        public static List<AbilityButton> abilityButtonsList = new List<AbilityButton>();

        private void OnEnable()
        {
            foreach (string name in AbilityFactory_Static.GetAbilityNames())
            {
                var button = Instantiate(buttonPrefab);
                abilityButtonsList.Add(button);

                button.gameObject.name = name + " Button";
                button.SetAbilityName(name);
                button.transform.SetParent(transform);
            }
        }

    }
}
