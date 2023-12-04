using UnityEngine;

namespace _3._Scripts.Animations
{
    public class ClassicAnimation: AnimationBase
    {
        private readonly Animator _animator;
        private static readonly int Speed = Animator.StringToHash("Speed");

        public ClassicAnimation(Animator animator)
        {
            _animator = animator;
        }
        
        public override void SetFloat(int id, float value)
        {
            _animator.SetFloat(id, value);
        }

        public override void SetTrigger(int id)
        {
            _animator.SetTrigger(id);
        }

        public override void SetBool(int id, bool value)
        {
            _animator.SetBool(id, value);
        }

        public override void SetInteger(int id, int value)
        {
            _animator.SetInteger(id, value);
        }
    }
}