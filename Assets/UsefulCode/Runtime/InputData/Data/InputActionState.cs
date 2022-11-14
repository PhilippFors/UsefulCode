using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player.Input.Data
{
    public class InputActionState
    {
        public Inputs InputType { get; private set; }
        public bool IsPressed => isPressed;
        public bool Triggered => action.triggered;
        public bool Released => action.WasReleasedThisFrame();
        public float PerformedTime { get; private set; }
        public float HoldTime {
            get {
                if (!IsPressed && !Released) {
                    return 0;
                }

                return Time.time - PerformedTime;
            }
        }

        public Action<InputAction.CallbackContext> SetStarted {
            set => action.started += value;
        }

        public Action<InputAction.CallbackContext> UnsetStarted {
            set => action.started -= value;
        }

        public Action<InputAction.CallbackContext> SetPerformed {
            set => action.started += value;
        }

        public Action<InputAction.CallbackContext> UnsetPerformed {
            set => action.started -= value;
        }

        public Action<InputAction.CallbackContext> SetCancelled {
            set => action.canceled += value;
        }

        public Action<InputAction.CallbackContext> UnsetCancelled {
            set => action.canceled -= value;
        }

        private readonly InputAction action;
        private bool isPressed;
        private bool wasEnabled;

        public InputActionState(InputAction action, Inputs inputType)
        {
            this.action = action;
            InputType = inputType;
            action.started += OnTriggered;
            action.canceled += OnTriggered;
        }

        private void OnTriggered(InputAction.CallbackContext context)
        {
            if (context.started) {
                isPressed = true;
                PerformedTime = Time.time;
            }
            else if (context.canceled) {
                isPressed = false;
            }
        }

        public T ReadValue<T>() where T : struct
        {
            return action.ReadValue<T>();
        }

        public void Started(Action<InputAction.CallbackContext> callback)
        {
            action.started += callback;
        }

        public void Canceled(Action<InputAction.CallbackContext> callback)
        {
            action.canceled += callback;
        }

        public void Performed(Action<InputAction.CallbackContext> callback)
        {
            action.performed += callback;
        }

        public void Enable()
        {
            action.Enable();
        }

        public void Disable()
        {
            action.Disable();
        }

        public InputAction GetAction() => action;
    }
}