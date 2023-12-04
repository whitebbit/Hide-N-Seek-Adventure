using _3._Scripts.Animations.Interfaces;
using _3._Scripts.Animations.Scriptable;
using _3._Scripts.Controls.Interfaces;
using _3._Scripts.Controls.Scriptable;
using UnityEngine;

namespace _3._Scripts.Game
{
    public class PlayerBase: MonoBehaviour
    {
        [SerializeField] private MovementConfig movementConfig;
        public IMovable Movable { get; private set; }
        public MovementConfig MovementConfig => movementConfig;
        
        [SerializeField] private AnimationConfig animationConfig;
        public IAnimatable Animatable { get; private set; }
        
        public AnimationConfig AnimationConfig => animationConfig;

        public void SetMovable(IMovable movable) => Movable = movable;
        public void SetAnimatable(IAnimatable animatable) => Animatable = animatable;
    }
}