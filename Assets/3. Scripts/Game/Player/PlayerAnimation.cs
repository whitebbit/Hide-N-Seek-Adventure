using _3._Scripts.Animations;
using UnityEngine;

namespace _3._Scripts.Game
{
    [RequireComponent(typeof(Player))]
    public class PlayerAnimation : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        private Player _player;
        private float _tempSpeed;
        private void Awake()
        {
            _player = GetComponent<Player>();
            _player.SetAnimatable(new ClassicAnimation(animator));
        }

        private void Start()
        {
            _player.Movable.Moved += Move;
            _player.Movable.Stopped += Stop;
        }

        private void OnDisable()
        {
            _player.Movable.Moved -= Move;
            _player.Movable.Stopped -= Stop;
        }

        private void Move(Vector3 direction)
        {
            _tempSpeed = direction.magnitude;
            _player.Animatable.SetFloat(_player.AnimationConfig.GetID("Speed"), _tempSpeed);
        }

        private void Stop()
        {
            _tempSpeed -= Time.deltaTime * (_player.MovementConfig.MoveSpeed * .75f);
            _player.Animatable.SetFloat(_player.AnimationConfig.GetID("Speed"), _tempSpeed);
        }
    }
}