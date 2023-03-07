using DemonstrationForLev.Model.Abstraction;

namespace DemonstrationForLev.Model.Implementation
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        protected override string GetAmimalSound()
        {
            string sound = "hav";
            return sound;
        }
    }
}
