using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class CameraFollower : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        [SerializeField] private float smoothTime = 0.3f;

        [SerializeField] private Vector3 Offset;

        private Vector3 velocity = Vector3.zero;

        private void Start()
        {
            Offset = transform.position - _target.position;
        }

        private void LateUpdate()
        {
            FollowTarget(_target);
        }

        private void FollowTarget(Transform target)
        {
            Vector3 targetPosition = target.position + Offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}
