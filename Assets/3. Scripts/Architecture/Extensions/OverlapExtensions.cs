using UnityEngine;

namespace _3._Scripts.Architecture.Extensions
{
    public static class OverlapExtensions
    {
        public static bool ObjectsInRadius(this Transform transform, Vector3 offset, float radius, LayerMask layerMask,
            Collider[] results, out int resultCount)
        {
            var position = transform.TransformPoint(offset);
            resultCount = Physics.OverlapSphereNonAlloc(position, radius, results, layerMask.value);
            return resultCount > 0;
        }
    }
}