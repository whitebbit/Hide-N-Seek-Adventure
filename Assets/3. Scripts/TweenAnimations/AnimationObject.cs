using System;
using _3._Scripts.Architecture.Scriptable.Animations;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

namespace _3._Scripts.TweenAnimations
{
    [Serializable]
    public class AnimationObject
    {
        [SerializeField] private Transform transform;
        [SerializeField] private TweenAnimation animation;

        private Tween _tween;
        
        public void Play()
        {
            if (_tween == null)
                _tween = animation.Animate(transform);
            else
                _tween.Play();
        }

        public void Pause()
        {
            _tween?.Pause();
        }

        public void Kill()
        {
            _tween?.Kill();
            _tween = null;
        }
    }
}