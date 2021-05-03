using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class CameraFollower : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Vector3 _offset;
        [SerializeField] private float _speed;

        private Vector3 moveDirection;

        private void Awake()
        {
            if (_target == null)
                Debug.LogError("CameraFollower does not have a target!!");
            
        }


        private void Update()
        {
            FollowTarget(_target);
        }

        void FollowTarget(Transform target)
        {
            moveDirection = target.position - _offset;
            transform.position = Vector3.Lerp(transform.position, moveDirection, _speed * Time.deltaTime);
        }
    }
}
