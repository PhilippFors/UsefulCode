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

        public Action<InputAction.CallbackContext> SetStarted {
            set {
                action.started += value;
                startedCallbacks.Add(value);
            }
        }

        public Action<InputAction.CallbackContext> UnsetStarted {
            set {
                action.started -= value;
                startedCallbacks.Remove(value);
            }
        }

        public Action<InputAction.CallbackContext> SetPerformed {
            set {
                action.started += value;
                performedCallbacks.Add(value);
            }
        }

        public Action<InputAction.CallbackContext> UnsetPerformed {
            set {
                action.started -= value;
                performedCallbacks.Remove(value);
            }
        }

        public Action<InputAction.CallbackContext> SetCancelled {
            set {
                action.canceled += value;
                canceledCallbacks.Add(value);
            }
        }

        public Action<InputAction.CallbackContext> UnsetCancelled {
            set {
                action.canceled -= value;
                canceledCallbacks.Remove(value);
            }
        }

        private readonly List<Action<InputAction.CallbackContext>> startedCallbacks =
            new List<Action<InputAction.CallbackContext>>();

        private readonly List<Action<InputAction.CallbackContext>> performedCallbacks =
            new List<Action<InputAction.CallbackContext>>();

        private readonly List<Action<InputAction.CallbackContext>> canceledCallbacks =
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

        public void Block()
        {
            blocked = true;
            foreach (var c in startedCallbacks) {
                action.started -= c;
            }

            foreach (var c in performedCallbacks) {
                action.performed -= c;
            }

            foreach (var c in canceledCallbacks) {
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

            foreach (var c in canceledCallbacks) {
                action.canceled += c;
            }
        }
    }
}