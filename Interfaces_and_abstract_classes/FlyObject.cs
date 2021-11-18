using System;

namespace Epam.Interface
{
    // структура для рассчета координат объекта
    public struct Coordinate
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

    public class FlyObject
    {
        //коэффициент для рассчета ребер куба при движении на 1 метр в 3D плоскости
        static double step_direction_3d = 1 / (double)Math.Sqrt(3);
        //коэффициент для сторон квадрата при движении на 1 метр в 2D плоскости
        static double step_direction_2d = 1 / (double)Math.Sqrt(2);
        
        public int Time = 0;
        public double SpeedMetre = 0;
        public int SpeedKM = 0;
        public double Destination = 0;

        // поле для работы с координатами объекта
        public Coordinate CurrentState;

        // метод преобразования скорости из км/ч на м/с
        public void ConvertSpeedToMetre(int km)        
        {
            SpeedMetre = km * 1000 / 3600;
        }

        // метод изменения текущих координат при движении объекта по 3D плоскости
        public void FlyStep_3d(double metre)        
        {
            CurrentState.use_X += (step_direction_3d * metre);
            CurrentState.use_Y += (step_direction_3d * metre);
            CurrentState.use_Z += (step_direction_3d * metre);
        }

        // метод изменения текущих координат при движении объекта по 2D плоскости
        public void FlyStep_2d(double metre)        
        {
            CurrentState.use_X += (step_direction_2d * metre);
            CurrentState.use_Y += (step_direction_2d * metre);
        }

        // метод получения времени полета
        public int GetFlyTime()        
        {
            return Time;
        }

        // метод получения дистанции полета
        public double FlyTo()        
        {
            return Destination;
        }
    }
}
