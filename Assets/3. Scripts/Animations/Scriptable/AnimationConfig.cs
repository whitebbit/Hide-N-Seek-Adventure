using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace _3._Scripts.Animations.Scriptable
{
    public abstract class AnimationConfig: ScriptableObject
    {
        protected abstract IEnumerable<string> Parameters();
        
        public int GetID(string id)
        {
            var obj = Parameters().FirstOrDefault(o => o == id);

            if (obj == null)
            {
                throw new System.ArgumentException($"'{id}' not found on parameters");
            }
            
            return Animator.StringToHash(obj);
        }
    }
}