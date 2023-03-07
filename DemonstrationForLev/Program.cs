using DemonstrationForLev.View.Abstraction;
using DemonstrationForLev.View.Implementation;

namespace DemonstrationForLev
{
    class Program
    {
        static void Main(string[] args)
        {
            IView view = new ConsoleView();
            view.StartView();
        }
    }
}


