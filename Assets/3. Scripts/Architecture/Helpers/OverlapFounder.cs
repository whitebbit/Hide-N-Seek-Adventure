using System;
using _3._Scripts.Architecture.Extensions;
using _3._Scripts.Architecture.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace _3._Scripts.Architecture.Helpers
{
    [Serializable]
    public class OverlapFounder
    {
        [SerializeField] private Transform point;
        [SerializeField] private float radius;
        [SerializeField] private LayerMask layerMask;

        private readonly Collider[] _overlapResults = new Collider[32];
        private int _overlapResultsCount;

        public bool ObjectsInRadius()
        {
            return point.ObjectsInRadius(Vector3.zero, radius, layerMask, _overlapResults, out _overlapResultsCount);
        }

        public T GetObject<T>()
        {
            for (var i = 0; i < _overlapResultsCount; i++)
            {
                if (!_overlapResults[i].TryGetComponent(out T obj)) continue;
                return obj;
            }

            return default;
        }

        public float DistanceToObject()
        {
            var obj = GetObject<IFoundable>();

            return obj == null ? 0f : Vector3.Distance(point.position, obj.Transform.position);
        }
    }
}