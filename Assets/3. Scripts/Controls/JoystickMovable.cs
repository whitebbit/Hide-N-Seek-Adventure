using UnityEngine;

namespace _3._Scripts.Controls
{
    public class JoystickMovable : MovableBase
    {
        private readonly Joystick _joystick;

        public JoystickMovable(Joystick joystick)
        {
            Input.multiTouchEnabled = false;
            _joystick = joystick;
        }

        protected override bool Moving()
        {
            return _joystick.Direction != Vector2.zero;
        }

        protected override Vector3 Direction()
        {
            return _joystick.Direction;
        }
    }
}