using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tutorials
{
    public class AbilityButton : MonoBehaviour
    {
        private string _abilityName;

        private void InitializeButton()
        {
            gameObject.GetComponent<Button>().onClick.AddListener(SetAbilityFunctionality);
        }

        void SetAbilityFunctionality()
        {
            AbilityFactory_Static.GetAbility(_abilityName).Process();
        }

        internal void SetAbilityName(string name)
        {
            GetComponentInChildren<Text>().text = name;
            _abilityName = name;
            InitializeButton();
        }
    }
}
