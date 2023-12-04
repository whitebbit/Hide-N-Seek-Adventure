using _3._Scripts.Animations;
using UnityEngine;

namespace _3._Scripts.Game
{
    [RequireComponent(typeof(PlayerBase))]
    public class PlayerAnimation : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        private PlayerBase _playerBase;
        private float _tempSpeed;
        private void Awake()
        {
            _playerBase = GetComponent<PlayerBase>();
            _playerBase.SetAnimatable(new ClassicAnimation(animator));
        }

        private void Start()
        {
            _playerBase.Movable.Moved += Move;
            _playerBase.Movable.Stopped += Stop;
        }

        private void OnDisable()
        {
            _playerBase.Movable.Moved -= Move;
            _playerBase.Movable.Stopped -= Stop;
        }

        private void Move(Vector3 direction)
        {
            _tempSpeed = direction.magnitude;
            _playerBase.Animatable.SetFloat(_playerBase.AnimationConfig.SpeedParameter, _tempSpeed);
        }

        private void Stop()
        {
            _tempSpeed -= Time.deltaTime * (_playerBase.MovementConfig.MoveSpeed * .75f);
            _playerBase.Animatable.SetFloat(_playerBase.AnimationConfig.SpeedParameter, _tempSpeed);
        }
    }
}