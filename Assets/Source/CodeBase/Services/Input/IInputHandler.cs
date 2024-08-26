using UnityEngine;

namespace Assets.Source.CodeBase
{
    public interface IInputHandler
    {
        Vector2 Axis { get; }
        bool IsAttackButtonUp();
    }
}