using System;

namespace Interfaces_and_abstract_classes
{
    internal class Plan : IFlyable
    {
        /*Самолет ограничена полетом на высоту 5000 метров(поле структуры Coordinate - Z).
        До достижения самолетом высоты 5000 метров движение осуществляется по диагонали 
        куба - d=a*3^(1/2), после движение по квадрату - d=a*2^(1/2). */

        static double step_direction_3d = 1 / (double)Math.Sqrt(3);
        //коэффициент для рассчета ребра куба при движении на 1 метр в 3D плоскости
        static double step_direction_2d = 1 / (double)Math.Sqrt(2);
        //коэффициент для стороны квадрата при движении на 1 метр в 2D плоскости
        private int time = 0;
        private double speed_metre = 0;
        private int speed_km = 200;
        private double destination = 0;
        private Coordinate current_state;// поле для работы с координатами объекта
        public Plan()
        {
            current_state = new Coordinate(0, 0, 0);
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
            double dest_mod = 0;
            for (int i = 0; i < time_fly; ++i)
            {
                ++time;
                destination += speed_metre;

                if (destination >= 800000) // ограничение полета самолета 800000 м.
                {
                    Console.WriteLine($"Полет самолета прерван на расстоянии {destination} м. в связи с " +
                        $"техническими ограничениями. Время полета {time}");
                    break;
                }
                
                if(current_state.use_Z < 5000) // ограничение высоты полета 5000 м.
                {
                    FlyStep_3d(speed_metre);
                }
                else { FlyStep_2d(speed_metre);}
                
                if (dest_mod - destination % 1000 > 800) // увеличение скорости каждые 10-й км. на 10 км/ч
                {
                    speed_km += 10;
                    speed_to_metre(speed_km);
                }

                dest_mod = destination % 1000;
            }
        }
        public void view_coordinete()
        // метод получения данных о координатах объекта
        {
            Console.WriteLine($"Координаты самолета: X {current_state.use_X}, " +
                $"Y {current_state.use_Y}, Z {current_state.use_Z}");           
        }
    }
    
}
