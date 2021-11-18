using System;

namespace Epam.Interface
{
    // Самолет ограничен полетом на высоту 5000 метров(поле структуры Coordinate - Z).
    // До достижения самолетом высоты 5000 метров движение осуществляется по диагонали 
    // куба - d=a*3^(1/2), после движение по квадрату - d=a*2^(1/2).
    internal class Plan : FlyObject, IFlyable
    {  
        public Plan()
        {
            CurrentState = new Coordinate(0, 0, 0);
            ConvertSpeedToMetre(200);
        }

        // метод записка полета на заданный интервал времени
        public void FlyRun(int TimeFly)       
        {
            double ModuleDectination = 0;
            for (int i = 0; i < TimeFly; ++i)
            {
                ++Time;
                Destination += SpeedMetre;

                if (Destination >= 800000) // ограничение полета самолета 800000 м.
                {
                    Console.WriteLine($"Полет самолета прерван на расстоянии {Destination} м. в связи с " +
                        $"техническими ограничениями. Время полета {Time}");
                    break;
                }
                
                if(CurrentState.use_Z < 5000) // ограничение высоты полета 5000 м.
                {
                    FlyStep_3d(SpeedMetre);
                }
                else { FlyStep_2d(SpeedMetre);}
                
                if (ModuleDectination - Destination % 1000 > 800) // увеличение скорости каждые 10-й км. на 10 км/ч
                {
                    SpeedKM += 10;
                    ConvertSpeedToMetre(SpeedKM);
                }

                ModuleDectination = Destination % 1000;
            }
        }

        // метод получения данных о координатах объекта
        public void ViewCoordinete()        
        {
            Console.WriteLine($"Координаты самолета: X {CurrentState.use_X}, " +
                $"Y {CurrentState.use_Y}, Z {CurrentState.use_Z}");           
        }
    }
    
}
