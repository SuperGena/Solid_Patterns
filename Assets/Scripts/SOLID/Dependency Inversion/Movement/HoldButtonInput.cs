using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Tutorials
{
    public class HoldButtonInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private MobilePhoneInput mobilePhoneInput;

        [SerializeField] private float moveDirection;
        
        [SerializeField] private bool isHorizontalMovement;
        
        bool pointerDown = false;

        public UnityEvent onHoldingButton;

        public void OnPointerDown(PointerEventData eventData)
        {
            pointerDown = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Reset();
        }

        private void Awake()
        {
            
            mobilePhoneInput = FindObjectOfType<MobilePhoneInput>();
        }

        // Update is called once per frame
        void Update()
        {
            if (pointerDown)
            {
                if (isHorizontalMovement)
                {
                    mobilePhoneInput.Horizontal = SetMovementDirection(moveDirection);
                }
                else
                {
                    mobilePhoneInput.Vertical = SetMovementDirection(moveDirection);
                }
            }
        }

        private float SetMovementDirection(float direction)
        {
            return direction;
        }

        private void Reset()
        {
            mobilePhoneInput.Horizontal = 0f;
            mobilePhoneInput.Vertical = 0f;
            
            pointerDown = false;
        }
    }
}
