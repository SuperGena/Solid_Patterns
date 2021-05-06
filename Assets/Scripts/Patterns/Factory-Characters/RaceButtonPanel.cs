using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class RaceButtonPanel : MonoBehaviour
    {
        [SerializeField] private RaceButton buttonPrefab;

        public static List<RaceButton> raceButtonsList = new List<RaceButton>();

        private void OnEnable()
        {
            foreach (string name in RaceFactory.GetRaceNames())
            {
                var button = Instantiate(buttonPrefab);
                raceButtonsList.Add(button);

                button.gameObject.name = $"{name} Button";
                button.SetAbilityName(name);
                button.transform.SetParent(transform);
            }
        }
    }
}
