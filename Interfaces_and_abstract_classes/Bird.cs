using System;

namespace Epam.Interface
{
    // Птица ограничена полетом на высоту 1000 метров(поле структуры Coordinate - Z).
    // До достижения птицей высоты 1000 метров движение осуществляется по диагонали 
    // куба - d=a*3^(1/2), после движение по квадрату - d=a*2^(1/2).
    internal class Bird : FlyObject, IFlyable
    {        
        Random RandomSpeed = new Random();
        public Bird()
        {
            CurrentState = new Coordinate(0, 0, 0);
            SpeedKM = RandomSpeed.Next(1, 20);
            ConvertSpeedToMetre(SpeedKM);
        }

        // метод записка полета на заданный интервал времени
        public void FlyRun(int TimeFly)        
        {
            for (int i = 0; i < TimeFly; ++i)
            {
                ++Time;
                Destination += SpeedMetre;

                if (Destination >= 10000) // ограничение полета птицы 10000 м.
                {
                    Console.WriteLine($"Полет птицы прерван на расстоянии {Destination} м. в связи с " +
                        $"техническими ограничениями. Время полета {Time}");
                    break;
                }
                
                if (CurrentState.use_Z < 1000) // ограничение высоты полета 1000 м.
                {
                    FlyStep_3d(SpeedMetre);
                }
                else { FlyStep_2d(SpeedMetre); }
                                
            }
        }

        // метод получения данных о координатах объекта
        public void ViewCoordinete()           
        {
            Console.WriteLine($"Координаты птицы: X {CurrentState.use_X}, " +
                $"Y {CurrentState.use_Y}, Z {CurrentState.use_Z}");            
        }
    }
    
}
