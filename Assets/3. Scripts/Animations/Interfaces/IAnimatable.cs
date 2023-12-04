namespace _3._Scripts.Animations.Interfaces
{
    public interface IAnimatable
    {
        public void SetFloat(int id, float value);
        public void SetTrigger(int id);
        public void SetBool(int id, bool value);
        public void SetInteger(int id, int value);
    }
}