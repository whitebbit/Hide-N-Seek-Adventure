using _3._Scripts.Architecture.Scriptable.Animations;
using _3._Scripts.FSM.Base;
using _3._Scripts.TweenAnimations;
using DG.Tweening;
using UnityEngine;

namespace _3._Scripts.Game.AI.FSM.States
{
    public class BotFearState: State
    {
        private readonly AnimationObject _animationObject;
        public BotFearState(AnimationObject animation)
        {
            _animationObject = animation;
        }
        
        public override void OnEnter()
        {
            base.OnEnter();
            _animationObject.Play();
        }

        public override void Update()
        {
           
        }

        public override void FixedUpdate()
        {
           
        }

        public override void OnExit()
        {
            base.OnExit();
            _animationObject.Kill();
        }
    }
}