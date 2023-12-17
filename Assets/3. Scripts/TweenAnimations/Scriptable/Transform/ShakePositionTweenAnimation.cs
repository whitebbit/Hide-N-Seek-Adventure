using _3._Scripts.Architecture.Scriptable.Animations;
using DG.Tweening;
using UnityEngine;


namespace _3._Scripts.TweenAnimations.Scriptable.Transform
{
    [CreateAssetMenu(menuName = "Configs/Tweens/Shake Position", fileName = "ShakePositionTween")]
    public class ShakePositionTweenAnimation : TweenAnimation
    {
        [Header("Shake Position Settings")] [SerializeField, Tooltip("The duration of the tween")]
        private float duration;

        [SerializeField, Tooltip("The shake strength")]
        private float strength = 1f;

        [SerializeField, Tooltip("Indicates how much will the shake vibrate")]
        private int vibrato = 10;

        [SerializeField,
         Tooltip(
             "Indicates how much the shake will be random (0 to 180 - values higher than 90 kind of suck, so beware). Setting it to 0 will shake along a single direction.")]
        private float randomness = 90f;

        [SerializeField, Tooltip("If TRUE the tween will smoothly snap all values to integers")]
        private bool snapping;

        [SerializeField,
         Tooltip(
             "If TRUE the shake will automatically fadeOut smoothly within the tween's duration, otherwise it will not")]
        private bool fadeOut = true;

        [SerializeField, Tooltip("Randomness mode")]
        private ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full;
         
        protected override Tween DoAnimation(object obj)
        {
            var transform = obj as UnityEngine.Transform;

            if (transform == null) throw new System.Exception("Object not cast to Transform");

            return transform.DOShakePosition(duration, strength, vibrato, randomness, snapping, fadeOut,
                randomnessMode);
        }
    }
}