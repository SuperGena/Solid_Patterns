using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    [RequireComponent(typeof(GetPlayerInput))]
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float speed = 30f;

        private GetPlayerInput playerInput;

        private void Awake()
        {
            playerInput = GetComponent<GetPlayerInput>();
        }

        private void Update()
        {
            MovePlayer();
        }

        void MovePlayer()
        {
            Vector3 movement = transform.position;
            movement += new Vector3(playerInput.Horizontal * Time.deltaTime * speed, 0, playerInput.Vertical * Time.deltaTime * speed) ;
            transform.position = movement;
        }
    }
}
