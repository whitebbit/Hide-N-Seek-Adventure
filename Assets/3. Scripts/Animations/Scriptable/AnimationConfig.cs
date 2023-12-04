using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace _3._Scripts.Animations.Scriptable
{
    [CreateAssetMenu(menuName = "Configs/Animations/Animations", fileName = "AnimationConfig")]
    public class AnimationConfig: ScriptableObject
    {
        [SerializeField] private string speedParameter;

        public int SpeedParameter => Animator.StringToHash(speedParameter);
    }
}