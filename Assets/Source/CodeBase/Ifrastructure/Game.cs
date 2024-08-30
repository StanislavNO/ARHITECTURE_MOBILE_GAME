using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class Game
    {
        public static IInputHandler InputService { get; private set; }

        public Game()
        {
            RegisterInput();
        }

        private void RegisterInput()
        {
            if (Application.isEditor)
                InputService = new StandaloneInputHandler();
            else
                InputService = new MobileInputHandler();
        }
    }
}