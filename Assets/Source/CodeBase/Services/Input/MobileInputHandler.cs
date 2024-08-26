using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class MobileInputHandler : InputHandler
    {
        public override Vector2 Axis => GetJoystickInputAxis();
    }
}