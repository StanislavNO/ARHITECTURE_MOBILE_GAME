using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class CharacterMover : MonoBehaviour
    {
        [SerializeField] private CharacterController _controller;
        [SerializeField][Range(0.1f, 5f)] private float _speed;

        private IInputHandler _input;
        private Camera _camera;
        private Transform _transform;

        private void Awake()
        {
            _input = Game.InputService;
            _transform = transform;
        }

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 movementVector = Vector3.zero;

            if (_input.Axis.sqrMagnitude > Constants.Epsilon)
            {
                movementVector = _camera.transform.TransformDirection(_input.Axis);
                movementVector.y = 0;
                movementVector.Normalize();
                _transform.forward = movementVector;
            }

            movementVector += Physics.gravity;

            _controller.Move(movementVector * Time.deltaTime * _speed);
        }
    }
}