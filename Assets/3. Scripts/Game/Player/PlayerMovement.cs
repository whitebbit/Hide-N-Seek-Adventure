using System;
using _3._Scripts.Controls;
using _3._Scripts.Controls.Interfaces;
using _3._Scripts.Controls.Scriptable;
using UnityEngine;

namespace _3._Scripts.Game
{
    [RequireComponent(typeof(PlayerBase))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Transform rotateObject;
        [Space] [SerializeField] private Joystick joystick;
        
        private Rigidbody _rigidbody;
        private PlayerBase _playerBase;

        private void Awake()
        {
            _playerBase = GetComponent<PlayerBase>();
            _rigidbody = GetComponent<Rigidbody>();

            _playerBase.SetMovable(new JoystickMovable(joystick));
        }

        private void Start()
        {
            _playerBase.Movable.Moved += Move;
            _playerBase.Movable.Stopped += Stop;
        }

        private void Update()
        {
            _playerBase.Movable.Move();
        }


        private void OnDisable()
        {
            _playerBase.Movable.Moved -= Move;
            _playerBase.Movable.Stopped -= Stop;
        }

        private void Move(Vector3 direction)
        {
            rotateObject.LookAt(rotateObject.position + direction);
            _rigidbody.velocity = direction * _playerBase.MovementConfig.MoveSpeed;
        }

        private void Stop()
        {
            if (_rigidbody != null)
                _rigidbody.velocity = Vector3.zero;
        }
    }
}