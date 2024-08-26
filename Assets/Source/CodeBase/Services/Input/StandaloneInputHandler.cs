using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class StandaloneInputHandler : InputHandler
    {
        private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";

        public override Vector2 Axis
        {
            get
            {
                Vector2 axis = GetJoystickInputAxis();

                if (axis == Vector2.zero)
                    axis = GetStandaloneInputAxis();

                return axis;
            }
        }

        private Vector2 GetStandaloneInputAxis() =>
            new(Input.GetAxis(HORIZONTAL), Input.GetAxis(VERTICAL));
    }
}