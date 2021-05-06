using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tutorials
{
    public class RaceButton : MonoBehaviour
    {
        private string _raceName;

        private void InitializeButton()
        {
            gameObject.GetComponent<Button>().onClick.AddListener(SetRaceFunctionality);
        }

        void SetRaceFunctionality()
        {
            RaceFactory.GetAbility(_raceName).Process();
        }

        internal void SetRaceName(string name)
        {
            GetComponentInChildren<Text>().text = name;
            _raceName = name;
            InitializeButton();
        }
    }
}
