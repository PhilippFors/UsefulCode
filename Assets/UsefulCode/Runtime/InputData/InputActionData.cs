using System;
using UnityEngine.InputSystem;

namespace UsefulCode.Input
{
    /// <summary>
    /// This class provides the usual input action functionality but extends it with extra functionality.
    /// </summary>
    public class InputActionData
    {
        public bool IsPressed { get; private set; }
        public bool Triggered => action.triggered;

        public Action<InputAction.CallbackContext> SetStarted
        {
            set { action.started += value; }
        }

        public Action<InputAction.CallbackContext> UnsetStarted
        {
            set { action.started -= value; }
        }

        public Action<InputAction.CallbackContext> SetPerformed
        {
            set { action.performed += value; }
        }

        public Action<InputAction.CallbackContext> UnsetPerformed
        {
            set { action.performed -= value; }
        }

        public Action<InputAction.CallbackContext> SetCanceled
        {
            set { action.canceled += value; }
        }

        public Action<InputAction.CallbackContext> UnsetCanceled
        {
            set { action.canceled -= value; }
        }

        private InputAction action;

        public InputActionData(InputActionProperty property)
        {
            action = property.action;
            action.started += ctx => IsPressed = true;
            action.canceled += ctx => IsPressed = false;
        }

        public T ReadValue<T>() where T : struct => action.ReadValue<T>();
        public void Enable() => action.Enable();
        public void Disable() => action.Disable();
        public InputAction GetAction() => action;
    }
}