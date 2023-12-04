using System;
using _3._Scripts.Controls.Interfaces;
using UnityEngine;

namespace _3._Scripts.Controls
{
    public abstract class MovableBase : IMovable
    {
        public event Action<Vector3> Moved;
        public event Action Stopped;
        
        protected abstract bool Moving();

        protected abstract Vector3 Direction();
        
        public void Move()
        {
            if (!Moving())
            {
                Stopped?.Invoke();
                return;
            }
            
            var direction = new Vector3(Direction().x, 0, Direction().y);
            Moved?.Invoke(direction);
        }
    }
}