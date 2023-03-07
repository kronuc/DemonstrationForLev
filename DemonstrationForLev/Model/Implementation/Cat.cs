using DemonstrationForLev.Model.Abstraction;

namespace DemonstrationForLev.Model.Implementation
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        protected override string GetAmimalSound()
        {
            return "myau";
        }
    }
}
