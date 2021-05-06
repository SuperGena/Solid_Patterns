using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tutorials
{
    public class RaceButtonPanel : MonoBehaviour
    {
        [SerializeField] private RaceButton buttonPrefab;

        public static List<RaceButton> raceButtonsList = new List<RaceButton>();

        private void OnEnable()
        {
            foreach (var name in RaceFactory.GetRaceNames())
            {

                //TODO: Change the way its working


                var button = Instantiate(buttonPrefab);
                //buttonPrefab = new RaceButton();
                button.SetRaceName(name);

                if (!raceButtonsList. Contains(button))
                {


                    raceButtonsList.Add(button);

                    button.gameObject.name = $"{name} Button";
                    //button.SetRaceName(name);
                    button.transform.SetParent(transform);
                    button.GetComponent<Button>().onClick.AddListener(DisableChoseRacePanel);
                }
                else
                {
                    button.GetComponent<Button>().onClick.AddListener(DisableChoseRacePanel);
                }
            }
            
        }
        private void OnDisable()
        {
            foreach (Button button in GetComponentsInChildren<Button>())
            {
                button.onClick.RemoveListener(DisableChoseRacePanel);
                //bu
            }
        }

        void DisableChoseRacePanel()
        {
            gameObject.SetActive(false);
        }
    }
}
