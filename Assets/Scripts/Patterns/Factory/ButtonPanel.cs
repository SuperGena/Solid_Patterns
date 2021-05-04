using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class ButtonPanel : MonoBehaviour
    {
        [SerializeField] private AbilityButton buttonPrefab;

        private void OnEnable()
        {
            foreach (string name in AbilityFactory_Static.GetAbilityNames())
            {
                var button = Instantiate(buttonPrefab);
                button.gameObject.name = name + " Button";
                button.SetAbilityName(name);
                button.transform.SetParent(transform);
            }
        }

    }
}
