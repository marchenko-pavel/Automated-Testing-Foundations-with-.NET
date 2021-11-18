using System;

namespace Epam.Interface
{    

    internal class Program
    {
        // вызов методов интерфейса IFlyable
        static void Action(IFlyable Flyable, int time_fly)
            
        {
            Flyable.FlyRun(time_fly);
            Flyable.ViewCoordinete();
            Console.WriteLine($"Время полета {Flyable.GetFlyTime()} секунд.");
            Console.WriteLine($"Расстояние полета {Flyable.FlyTo()} метров.");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            IFlyable Plan = new Plan();
            IFlyable Bird = new Bird();
            IFlyable Drone = new Drone();

            Action(Plan, 30000);
            Action(Bird, 30000);
            Action(Drone, 30000);                        
        }
    }
}
