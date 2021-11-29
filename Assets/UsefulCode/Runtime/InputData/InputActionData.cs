using System;
using UnityEngine.InputSystem;

namespace UsefulCode.Input
{
    public abstract class InputActionData
    {
    }

    /// <summary>
    /// This class provides the usual input action functionality but extends it with extra functionality.
    /// </summary>
    public class InputActionData<T> : InputActionData where T : struct
    {
        public bool IsPressed { get; private set; }
        public bool Triggered => action.triggered;
        public event Action<InputAction.CallbackContext> Started;
        public event Action<InputAction.CallbackContext> Performed;
        public event Action<InputAction.CallbackContext> Canceled;

        private InputAction action;

        public InputActionData(InputActionProperty property)
        {
            action = property.action;
            action.started += ctx => Started?.Invoke(ctx);
            action.started += ctx => IsPressed = true;

            action.performed += ctx => Performed?.Invoke(ctx);

            action.canceled += ctx => Canceled?.Invoke(ctx);
            action.canceled += ctx => IsPressed = false;
        }

        public T ReadValue() => action.ReadValue<T>();
        public void Enable() => action.Enable();
        public void Disable() => action.Disable();
    }
}