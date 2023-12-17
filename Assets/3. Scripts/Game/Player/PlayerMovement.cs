using System;
using _3._Scripts.Controls;
using _3._Scripts.Controls.Interfaces;
using _3._Scripts.Controls.Scriptable;
using UnityEngine;

namespace _3._Scripts.Game
{
    [RequireComponent(typeof(Player))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Transform rotateObject;
        [Space] [SerializeField] private Joystick joystick;
        
        private Rigidbody _rigidbody;
        private Player _player;

        private void Awake()
        {
            _player = GetComponent<Player>();
            _rigidbody = GetComponent<Rigidbody>();

            _player.SetMovable(new JoystickMovable(joystick));
        }

        private void Start()
        {
            _player.Movable.Moved += Move;
            _player.Movable.Stopped += Stop;
        }

        private void Update()
        {
            _player.Movable.Move();
        }


        private void OnDisable()
        {
            _player.Movable.Moved -= Move;
            _player.Movable.Stopped -= Stop;
        }

        private void Move(Vector3 direction)
        {
            rotateObject.LookAt(rotateObject.position + direction);
            _rigidbody.velocity = direction * _player.MovementConfig.MoveSpeed;
        }

        private void Stop()
        {
            if (_rigidbody != null)
                _rigidbody.velocity = Vector3.zero;
        }
    }
}