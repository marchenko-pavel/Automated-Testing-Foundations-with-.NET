using System;

namespace Interfaces_and_abstract_classes
{
    internal class Drone : IFlyable
    {
        /*Дрон ограничен полетом на высоту 300 метров(поле структуры Coordinate - Z).
        До достижения дроном высоты 300 метров движение осуществляется по диагонали 
        куба - d=a*3^(1/2), после движение по квадрату - d=a*2^(1/2). */

        static double step_direction_3d = 1 / (double)Math.Sqrt(3);
        //коэффициент для рассчета ребра куба при движении на 1 метр в 3D плоскости
        static double step_direction_2d = 1 / (double)Math.Sqrt(2);
        //коэффициент для стороны квадрата при движении на 1 метр в 2D плоскости
        private int time = 0;
        private double speed_metre = 0;
        private int speed_km = 0;
        private double destination = 0;
        private Coordinate current_state;// поле для работы с координатами объекта
        Random random = new Random();
        
        public Drone()
        {
            current_state = new Coordinate(0, 0, 0);
            speed_km = random.Next(1, 20);
            speed_to_metre(speed_km);
        }
        public void speed_to_metre(int km)
        // метод преобразования скорости из км/ч на м/с
        {
            speed_metre = km * 1000 / 3600;
        }
        public void FlyStep_3d(double metre)
        // метод изменения текущих координат при движении объекта по 3D плоскости
        {
            current_state.use_X += (step_direction_3d * metre);
            current_state.use_Y += (step_direction_3d * metre);
            current_state.use_Z += (step_direction_3d * metre);
        }
        public void FlyStep_2d(double metre)
        // метод изменения текущих координат при движении объекта по 2D плоскости
        {
            current_state.use_X += (step_direction_2d * metre);
            current_state.use_Y += (step_direction_2d * metre);
        }
        public int GetFlyTime()
        // метод получения времени полета
        {
            return time;
        }
        public double FlyTo()
        // метод получения дистанции полета
        {
            return destination;
        }
        public void Fly_Run(int time_fly)
        // метод записка полета на заданный интервал времени
        {
            for (int i = 0; i < time_fly; ++i)
            {
                ++time;

                if (destination >= 5000) // ограничение полета дрона 5000 м.
                {
                    Console.WriteLine($"Полет дрона прерван на расстоянии {destination} м. в связи с " +
                        $"техническими ограничениями. Время полета {time}");
                    break;
                }

                if (time % 600 <= 540) // движние каждые 9 минут, на 10-ю - зависает
                {
                    if (current_state.use_Z < 300)// ограничение высоты полета 300 м.
                    {
                        FlyStep_3d(speed_metre);
                    }
                    else { FlyStep_2d(speed_metre); }
                    
                    destination += speed_metre;
                }                
            }
        }

        public void view_coordinete()
        // метод получения данных о координатах объекта
        {
            Console.WriteLine($"Координаты дрона: X {current_state.use_X}, " +
                $"Y {current_state.use_Y}, Z {current_state.use_Z}");            
        }
    }
}
