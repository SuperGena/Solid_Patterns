using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class MoveObject : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;
        
        private IMovementInputGetter movementInputGetter = null;

        private void Awake()
        {
            movementInputGetter = GetComponent<IMovementInputGetter>();
        }

        private void Update()
        {
            Vector3 movement = new Vector3
            {
                x = movementInputGetter.Horizontal,
                y = 0f,
                z = movementInputGetter.Vertical,
            }.normalized;

            movement *= _speed * Time.deltaTime;

            transform.Translate(movement);
        }
    }
}
