using System;

namespace DemonstrationForLev.Model.Abstraction
{
    public abstract class Animal
    {
        public string Name { get; }

        protected Animal(string name)
        {
            Name = name;
        }

        public void SaySomething()
        {
            var sound = GetAmimalSound();

            Console.WriteLine($"Hi, I am {Name}, {sound}");
        }

        protected abstract string GetAmimalSound();

    }
}
