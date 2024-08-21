using UnityEngine;

namespace Assets.Source.CodeBase
{
    public interface IInputHandler
    {
        Vector2 Axis { get; }
        bool IsAttackButtonUp();
    }

    public class InputHandler : IInputHandler
    {
        public Vector2 Axis => throw new System.NotImplementedException();

        public bool IsAttackButtonUp()
        {
            throw new System.NotImplementedException();
        }
    }
}