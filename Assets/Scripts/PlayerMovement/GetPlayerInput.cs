using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class GetPlayerInput : MonoBehaviour
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }
        public bool FireWeapon { get; private set; }

        public event Action OnFire = delegate { };

        private void Update()
        {
            Horizontal = Input.GetAxis("Horizontal");
            Vertical = Input.GetAxis("Vertical");
            FireWeapon = Input.GetKey(KeyCode.Mouse0);
            if (FireWeapon)
                OnFire();
        }
    }
}
