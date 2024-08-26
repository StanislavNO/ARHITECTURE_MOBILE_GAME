using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Assets.Source.CodeBase
{
    public abstract class InputHandler : IInputHandler
    {
        public InputHandler()
        {
            Joystick = Object.FindObjectOfType<FloatingJoystick>();

            if (Joystick is null)
                throw new ArgumentNullException(nameof(Joystick));
        }

        public abstract Vector2 Axis { get; }
        protected FloatingJoystick Joystick { get; private set; }

        public bool IsAttackButtonUp()
        {
            //SimpleInput.GetButtonUp("Fire");
            return true;
        }

        protected Vector2 GetJoystickInputAxis() =>
            new(Joystick.Horizontal, Joystick.Vertical);
    }
}