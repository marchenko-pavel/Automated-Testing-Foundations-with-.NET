using System;

namespace Epam.OOP
{    
    class Program
    {
        static void Main(string[] args)
        {
            Engine EngineOfCar = new Engine(70, 1.8, "gasoline", "VS52626264");
            Chassis ChassisOfCar = new Chassis(4, 700);
            Transmission TransmissionOfCar = new Transmission("auto", 5, "BMV");

            Engine EngineOfTruck = new Engine(300, 5.8, "diesel", "VSGESRH578");
            Chassis ChassisOfTruck = new Chassis(10, 8700);
            Transmission TransmissionOfTruck = new Transmission("mechanical", 6, "MAN");

            Engine EngineOfBus = new Engine(150, 2.8, "diesel", "VHDSJRTJR65");
            Chassis ChassisOfBus = new Chassis(6, 2500);
            Transmission TransmissionOfBus = new Transmission("mechanical", 4, "VOLVO");

            Engine EngineOfScooter = new Engine(10, 0.8, "gasoline", "SGDSRTJR74");
            Chassis ChassisOfScooter = new Chassis(2, 150);
            Transmission TransmissionOfScooter = new Transmission("mechanical", 3, "Suzuki");

            Car Car = new Car(EngineOfCar, ChassisOfCar, TransmissionOfCar);
            Truck Truck = new Truck(EngineOfTruck, ChassisOfTruck, TransmissionOfTruck);
            Bus Bus = new Bus(EngineOfBus, ChassisOfBus, TransmissionOfBus);
            Scooter Scooter = new Scooter(EngineOfScooter, ChassisOfScooter, TransmissionOfScooter);
                        
            Car.PrintInfo();
            Console.WriteLine();
            Truck.PrintInfo();
            Console.WriteLine();
            Bus.PrintInfo();
            Console.WriteLine();
            Scooter.PrintInfo();
        }
    }
}

