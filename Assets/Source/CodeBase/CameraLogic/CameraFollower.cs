using System;
using UnityEngine;

namespace Assets.Source.CodeBase
{
    public class CameraFollower : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _rotationAngleX;
        [SerializeField] private float _distance;
        [SerializeField] private float _offsetY;

        private void LateUpdate()
        {
            if (_target == null)
                return;

            Quaternion rotation = Quaternion.Euler(Vector3.right * _rotationAngleX);
            Vector3 position = rotation * new Vector3(0, 0, -_distance) + FollowingPointPosition();

            transform.rotation = rotation;
            transform.position = position;
        }

        public void SetTarget(Transform target) =>
            _target = target;

        public void SetRotationX(float value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _rotationAngleX = value;
        }

        public void SetDistance(float value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _distance = value;
        }

        public void SetOffsetY(float value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _offsetY = value;
        }

        private Vector3 FollowingPointPosition()
        {
            Vector3 followingPosition = _target.position;
            followingPosition.y += _offsetY;
            return followingPosition;
        }
    }
}