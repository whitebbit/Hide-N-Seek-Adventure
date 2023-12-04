using UnityEngine;

namespace _3._Scripts.Controls.Scriptable
{
    [CreateAssetMenu(menuName = "Configs/Controls/Movement", fileName = "MovementConfig", order = 0)]
    public class MovementConfig: ScriptableObject
    {
        [SerializeField] private float moveSpeed;

        public float MoveSpeed => moveSpeed;
    }
}