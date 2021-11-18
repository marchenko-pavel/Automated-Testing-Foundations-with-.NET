using System;

namespace Interfaces_and_abstract_classes
{
    public struct Coordinate
        // структура для координат объекта
    {
        private double X;
        private double Y;
        private double Z;

        public Coordinate(double X, double Y, double Z) 
        { 
            this.X = X; this.Y = Y; this.Z = Z; 
        }
        public double use_X
        {
            get => X;
            set => X = value;
        }
        public double use_Y
        {
            get => Y;
            set => Y = value;
        }
        public double use_Z
        {
            get => Z;
            set => Z = value;
        }
    }

    internal class Program
    {
        static void Action(IFlyable Flyable, int time_fly)
            // метод для вызова методов интерфейса IFlyable
        {
            Flyable.Fly_Run(time_fly);
            Flyable.view_coordinete();
            Console.WriteLine($"Время полета {Flyable.GetFlyTime()} секунд.");
            Console.WriteLine($"Расстояние полета {Flyable.FlyTo()} метров.");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            IFlyable plan = new Plan();
            IFlyable bird = new Bird();
            IFlyable drone = new Drone();

            Action(plan, 30000);
            Action(bird, 30000);
            Action(drone, 30000);                        
        }
    }
}
