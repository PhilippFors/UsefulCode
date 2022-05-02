using System;
using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace UsefulCode.Input
{
    public enum InputType
    {
        Gameplay,
        Menu
    }

    /// <summary>
    /// This class provides the usual input action functionality but extends it with extra functionality.
    /// </summary>
    public class InputActionData
    {
        public InputType GetInputType { get; private set; }

        public bool IsPressed {
            get {
                if (blocked) {
                    return false;
                }

                return isPressed;
            }
        }

        public bool Triggered {
            get {
                if (blocked) {
                    return false;
                }

                return action.triggered;
            }
        }

        private readonly List<Action<InputAction.CallbackContext>> startedCallbacks =
            new List<Action<InputAction.CallbackContext>>();

        private readonly List<Action<InputAction.CallbackContext>> performedCallbacks =
            new List<Action<InputAction.CallbackContext>>();

        private readonly List<Action<InputAction.CallbackContext>> cancledCallbacks =
            new List<Action<InputAction.CallbackContext>>();

        private InputAction action;
        private bool blocked;
        private bool isPressed;

        public InputActionData(InputActionProperty property, InputType inputType)
        {
            GetInputType = inputType;
            action = property.action;
            action.started += ctx => isPressed = true;
            action.canceled += ctx => isPressed = false;
        }

        public T ReadValue<T>() where T : struct
        {
            if (blocked) {
                return default;
            }

            return action.ReadValue<T>();
        }

        public void Enable() => action.Enable();
        public void Disable() => action.Disable();
        public InputAction GetAction() => action;

        public void SetStarted(Action<InputAction.CallbackContext> callback)
        {
            action.started += callback;
            startedCallbacks.Add(callback);
        }

        public void UnsetStarted(Action<InputAction.CallbackContext> callback)
        {
            action.started -= callback;
            startedCallbacks.Remove(callback);
        }

        public void SetPerformed(Action<InputAction.CallbackContext> callback)
        {
            action.performed += callback;
            performedCallbacks.Add(callback);
        }

        public void UnsetPerformed(Action<InputAction.CallbackContext> callback)
        {
            action.performed -= callback;
            performedCallbacks.Remove(callback);
        }

        public void SetCanceled(Action<InputAction.CallbackContext> callback)
        {
            action.canceled += callback;
            cancledCallbacks.Add(callback);
        }

        public void UnsetCanceled(Action<InputAction.CallbackContext> callback)
        {
            action.canceled -= callback;
            cancledCallbacks.Remove(callback);
        }

        public void Block()
        {
            blocked = true;
            foreach (var c in startedCallbacks) {
                action.started -= c;
            }

            foreach (var c in performedCallbacks) {
                action.performed -= c;
            }

            foreach (var c in cancledCallbacks) {
                action.canceled -= c;
            }
        }

        public void UnBlock()
        {
            blocked = false;
            foreach (var c in startedCallbacks) {
                action.started += c;
            }

            foreach (var c in performedCallbacks) {
                action.performed += c;
            }

            foreach (var c in cancledCallbacks) {
                action.canceled += c;
            }
        }
    }
}