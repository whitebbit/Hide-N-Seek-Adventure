using _3._Scripts.Animations.Interfaces;
using UnityEngine;

namespace _3._Scripts.Animations
{
    public abstract class AnimationBase: IAnimatable
    {
        public abstract void SetFloat(int id, float value);

        public abstract void SetTrigger(int id);

        public abstract void SetBool(int id, bool value);

        public abstract void SetInteger(int id, int value);
    }
}