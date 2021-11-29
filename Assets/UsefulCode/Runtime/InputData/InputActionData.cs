using System;
using UnityEngine.InputSystem;

namespace UsefulCode.Input
{
    public abstract class InputActionData
    {
        public bool IsPressed { get; protected set; }
        public bool Triggered => action.triggered;
        public bool Released { get; protected set; }
        
        protected InputAction action;
        
        public abstract void Tick();
        public void Enable() => action.Enable();
        public void Disable() => action.Disable();
    }
    
    /// <summary>
    /// This class provides the usual input action functionality but extends it with extra functionality.
    /// </summary>
    public class InputActionData<T> : InputActionData where T : struct
    {
        public event Action<InputAction.CallbackContext> Started;
        public event Action<InputAction.CallbackContext> Performed;
        public event Action<InputAction.CallbackContext> Canceled;
        
        public InputActionData(InputActionProperty property)
        {
            action = property.action;
            action.started += ctx => Started?.Invoke(ctx);
            action.started += ctx => IsPressed = true;

            action.performed += ctx => Performed?.Invoke(ctx);

            action.canceled += ctx => Canceled?.Invoke(ctx);
            action.canceled += ctx => IsPressed = false;
        }

        public override void Tick()
        {
            if (action.phase == InputActionPhase.Canceled) {
                Released = true;
            }
            else {
                Released = false;
            }
        }

        public T ReadValue() => action.ReadValue<T>();
    }
}