using DemonstrationForLev.Model.Abstraction;
using DemonstrationForLev.Model.Implementation;
using DemonstrationForLev.View.Abstraction;
using System;

namespace DemonstrationForLev.View.Implementation
{
    public class ConsoleView : IView
    {
        private Animal _cat;
        private Animal _dog;

        public ConsoleView()
        {

            _cat = new Cat("stepan");
            _dog = new Dog("roman");
        }

        public void StartView()
        {
            Console.WriteLine("welcome");
            while (true)
            {
                Console.WriteLine($"Options\n" +
                    $"1 - cat sound\n" +
                    $"2 - dog sound\n" +
                    $"3 - exit\n");

                var userInput = Console.ReadLine();

                if (userInput == "3")
                {
                    Console.WriteLine("by");
                    break;
                }

                switch (userInput)
                {
                    case "1":
                        _cat.SaySomething();
                        break;

                    case "2":
                        _cat.SaySomething();
                        break;

                    default:
                        Console.WriteLine("wring input");
                        break;
                }

            }
        }
    }
}
