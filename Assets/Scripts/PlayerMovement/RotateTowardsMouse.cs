using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class RotateTowardsMouse : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private float _rotationSpeed;

        public Vector3 WorldPosition { get; private set; }
        
        private void Awake()
        {
            _camera = Camera.main;
            GetComponent<GetPlayerInput>().OnFire += GetMouseToWorldPosition;

        }

        void Start()
        {
                GetMouseToWorldPosition();
        }

        void GetMouseToWorldPosition()
        {

            Plane plane = new Plane(Vector3.up, 0);

            float distance;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (plane.Raycast(ray, out distance))
            {
                WorldPosition = ray.GetPoint(distance);
                RotateTowardsTarget(WorldPosition);
            }
        }

        void RotateTowardsTarget(Vector3 targetPosition)
        {
            Vector3 targetDirection = targetPosition - transform.position;

            float singleStep = _rotationSpeed * Time.deltaTime;

            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection - new Vector3(0, targetDirection.y, 0), singleStep, 0.0f);

            Debug.DrawRay(transform.position, newDirection, Color.red);

            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
}
