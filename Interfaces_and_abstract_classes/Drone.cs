using System;

namespace Epam.Interface
{
    // Дрон ограничен полетом на высоту 300 метров(поле структуры Coordinate - Z).
    // До достижения дроном высоты 300 метров движение осуществляется по диагонали 
    // куба - d=a*3^(1/2), после движение по квадрату - d=a*2^(1/2).
    internal class Drone : FlyObject, IFlyable
    {                  
        Random RandomSpeed = new Random();
        
        public Drone()
        {
            CurrentState = new Coordinate(0, 0, 0);
            SpeedKM = RandomSpeed.Next(1, 20);
            ConvertSpeedToMetre(SpeedKM);
        }

        // метод запуска полета на заданный интервал времени
        public void FlyRun(int TimeFly)        
        {
            for (int i = 0; i < TimeFly; ++i)
            {
                ++Time;

                if (Destination >= 5000) // ограничение полета дрона 5000 м.
                {
                    Console.WriteLine($"Полет дрона прерван на расстоянии {Destination} м. в связи с " +
                        $"техническими ограничениями. Время полета {Time}");
                    break;
                }

                if (Time % 600 <= 540) // движние каждые 9 минут, на 10-ю - зависает
                {
                    if (CurrentState.use_Z < 300)// ограничение высоты полета 300 м.
                    {
                        FlyStep_3d(SpeedMetre);
                    }
                    else { FlyStep_2d(SpeedMetre); }

                    Destination += SpeedMetre;
                }                
            }
        }

        // метод получения данных о координатах объекта
        public void ViewCoordinete()        
        {
            Console.WriteLine($"Координаты дрона: X {CurrentState.use_X}, " +
                $"Y {CurrentState.use_Y}, Z {CurrentState.use_Z}");            
        }
    }
}
