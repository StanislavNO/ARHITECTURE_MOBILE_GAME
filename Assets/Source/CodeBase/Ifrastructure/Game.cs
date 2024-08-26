using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class Game
    {
        private IInputHandler _input;

        public Game()
        {
            RegisterInput();
        }

        private void RegisterInput()
        {
            if (Application.isEditor)
                _input = new StandaloneInputHandler();
            else
                _input = new MobileInputHandler();
        }
    }
}