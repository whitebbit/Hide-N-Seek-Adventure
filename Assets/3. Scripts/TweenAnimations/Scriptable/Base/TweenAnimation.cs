using DG.Tweening;
using UnityEngine;

namespace _3._Scripts.Architecture.Scriptable.Animations
{
    public abstract class TweenAnimation : ScriptableObject
    {
        [Header("Tween Setting")]
        [SerializeField,
         Tooltip(
             "Sets the ease of the tween. If applied to Sequences eases the whole sequence animation")]
        protected Ease ease;

        [Space]
        [SerializeField,
         Tooltip(
             "Sets a delayed startup for the tween.")]
        protected float delay;

        [SerializeField,
         Tooltip(
             "Sets the looping options for the tween. Number of cycles to play (-1 for infinite - will be converted to 1 in case the tween is nested in a Sequence)")]
        protected int loops;

        [SerializeField,
         Tooltip(
             "LoopType.Restart: When a loop ends it will restart from the beginning.\nLoopType.Yoyo: When a loop ends it will play backwards until it completes another loop, then forward again, then backwards again, and so on and on and on.\nLoopType.Incremental: Each time a loop ends the difference between its endValue and its startValue will be added to the endValue, thus creating tweens that increase their values with each loop cycle.")]
        protected LoopType loopType;

        [Space]
        [SerializeField,
         Tooltip(
             "EXPERIMENTAL: inverts this tween, so that it will play from the end to the beginning (playing it backwards will actually play it from the beginning to the end). If TRUE the tween will be inverted, otherwise it won't")]
        protected bool inverted;

        [SerializeField,
         Tooltip(
             "If isRelative is TRUE sets the tween as relative (the end Value will be calculated as startValue + endValue instead of being used directly). In case of Sequences, sets all the nested tweens as relative.")]
        protected bool relative;
        
        public Tween Animate(object obj)
        {
            return DoAnimation(obj)
                .SetRelative(relative)
                .SetEase(ease)
                .SetDelay(delay)
                .SetInverted(inverted)
                .SetLoops(loops, loopType);
        }

        protected abstract Tween DoAnimation(object obj);
    }
}