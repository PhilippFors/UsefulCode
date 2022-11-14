using Player.Input.Data;
using UnityEngine;

namespace Player.Input.InputSystems
{
    [CreateAssetMenu(menuName = "Input/Systems/Player Input System")]
    public class PlayerInputSystem : BaseInputSystem
    {
        [field: SerializeField] public InputConfig inputConfig { get; private set; }
        private InputState cache; // Cache gets updated once every frame
        private int frameCount;
        
        public override InputState GetState()
        {
            if (cache == null) {
                cache = new InputState();
            }

            if (Time.frameCount == frameCount) {
                return cache;
            }
            
            ProcessInput(cache);
            frameCount = Time.frameCount;
            return cache;
        }

        public InputActionState Get(Inputs pattern) => inputConfig.Get(pattern);
        
        protected override void ProcessInput(InputState state)
        {
            var movement = inputConfig.Get(Inputs.Movement);
            state.movementTriggered = movement.Triggered;
            state.movementPressed = movement.IsPressed;
            state.movementDirection = movement.ReadValue<Vector2>();
            
            state.mouseDelta = inputConfig.ReadValue<Vector2>(Inputs.MouseDelta);
            
            state.mousePosition = inputConfig.ReadValue<Vector2>(Inputs.MousePosition);
            
            var mouseScroll = inputConfig.Get(Inputs.MouseScroll);
            state.mouseScrollTriggered = mouseScroll.Triggered;
            state.mouseScroll = mouseScroll.ReadValue<Vector2>().y;

            var jump = inputConfig.Get(Inputs.Jump);
            state.jumpTriggered = jump.Triggered;
            state.jumpPressed = jump.IsPressed;
            state.jumpReleased = jump.Released;
            state.jumpHoldTime = jump.HoldTime;

            var fire1 = inputConfig.Get(Inputs.Fire1);
            state.fire1Triggered = fire1.Triggered;
            state.fire1Pressed = fire1.IsPressed;
            state.fire1Released = fire1.Released;
            state.fire1HoldTime = fire1.HoldTime;

            var fire2 = inputConfig.Get(Inputs.Fire2);
            state.fire2Triggered = fire2.Triggered;
            state.fire2Pressed = fire2.IsPressed;
            state.fire2Released = fire2.Released;
            state.fire2HoldTime = fire2.HoldTime;
            
            var absorber = inputConfig.Get(Inputs.Absorber);
            state.absorberTriggered = absorber.Triggered;
            state.absorberPressed = absorber.IsPressed;
            state.absorberReleased = absorber.Released;
            state.absorberHoldTime = absorber.HoldTime;
            
            var melee = inputConfig.Get(Inputs.Melee);
            state.meleeTriggered = melee.Triggered;
            state.meleePressed = melee.IsPressed;
            state.meleeReleased = melee.Released;
            state.meleeHoldTime = melee.HoldTime;

            var slide = inputConfig.Get(Inputs.Slide);
            state.slideTriggered = slide.Triggered;
            state.slidePressed = slide.IsPressed;
            state.slideReleased = slide.Released;
            state.slideHoldTime = slide.HoldTime;

            var dodge = inputConfig.Get(Inputs.Dodge);
            state.dodgeTriggered = dodge.Triggered;
            state.dodgePressed = dodge.IsPressed;
            state.dodgeReleased = dodge.Released;
            state.dodgeHoldTime = dodge.HoldTime;

            var slot1 = inputConfig.Get(Inputs.Slot1);
            state.slot1Triggered = slot1.Triggered;
            state.slot1Pressed = slot1.IsPressed;
            state.slot1Released = slot1.Released;
            
            var slot2 = inputConfig.Get(Inputs.Slot2);
            state.slot2Triggered = slot2.Triggered;
            state.slot2Pressed = slot2.IsPressed;
            state.slot2Released = slot2.Released;
            
            var slot3 = inputConfig.Get(Inputs.Slot3);
            state.slot3Triggered = slot3.Triggered;
            state.slot3Pressed = slot3.IsPressed;
            state.slot3Released = slot3.Released;
            
            var slot4 = inputConfig.Get(Inputs.Slot4);
            state.slot4Triggered = slot4.Triggered;
            state.slot4Pressed = slot4.IsPressed;
            state.slot4Released = slot4.Released;
            
            var slot5 = inputConfig.Get(Inputs.Slot5);
            state.slot5Triggered = slot5.Triggered;
            state.slot5Pressed = slot5.IsPressed;
            state.slot5Released = slot5.Released;
        }
    }
}