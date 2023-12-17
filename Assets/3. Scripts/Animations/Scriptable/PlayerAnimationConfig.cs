using System.Collections.Generic;
using UnityEngine;

namespace _3._Scripts.Animations.Scriptable
{
    [CreateAssetMenu(menuName = "Configs/Animations/PlayerAnimation", fileName = "PlayerAnimationConfig")]
    public class PlayerAnimationConfig: AnimationConfig
    {
        [SerializeField] private string speed;

        protected override IEnumerable<string> Parameters()
        {
            return new List<string>
            {
                speed,
            };
        }
    }
}