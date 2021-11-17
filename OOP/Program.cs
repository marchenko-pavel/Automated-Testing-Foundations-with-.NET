using System;

namespace OOP
{
    public class Engine
    {
        protected int power;
        protected double volume;
        protected string type;
        protected string serial_number;

        public Engine(int power, double volume, string type, string serial_number)
        {
            this.power = power;
            this.volume = volume;
            this.type = type;
            this.serial_number = serial_number;
        }
        public void print_info()
        {
            Console.WriteLine($"Power of engine - {power}");
            Console.WriteLine($"Volume of engine - {volume}");
            Console.WriteLine($"Type of engine - {type}");
            Console.WriteLine($"Serial number - {serial_number}");
        }
    }

    public class Chassis
    {
        protected int wheels;
        protected int workload;

        public Chassis(int wheels, int workload)
        {
            this.wheels = wheels;
            this.workload = workload;
        }
        public void print_info()
        {
            Console.WriteLine($"Wheels of chassis - {wheels}");
            Console.WriteLine($"Workload of chassis - {workload}");
        }
    }

    public class Transmission
    {
        protected string type;
        protected int number_gear;
        protected string vendor;

        public Transmission(string type, int number_gear, string vendor)
        {
            this.type=type;
            this.number_gear = number_gear;
            this.vendor=vendor;
        }
        public void print_info()
        {
            Console.WriteLine($"Type of transmission - {type}");
            Console.WriteLine($"Number gear of transmission - {number_gear}");
            Console.WriteLine($"Vendor of transmission - {vendor}");
        }
    }

    public class Vehicle
    {
        protected Engine engine;
        protected Chassis chassis;
        protected Transmission transmission;

        public Vehicle(Engine engine, Chassis chassis, Transmission transmission)
        {
            this.engine = engine;
            this.chassis = chassis;
            this.transmission = transmission;
        }

        public virtual void print_info()
        {
            engine.print_info();
            chassis.print_info();
            transmission.print_info();
        }
    }

    public class Car: Vehicle
    {
        public Car(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
        }

        public override void print_info()
        {
            Console.WriteLine("Feature of passenger the car");
            base.print_info();
        }
    }

    public class Truck : Vehicle
    {
        public Truck(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
        }
        public override void print_info()
        {
            Console.WriteLine("Feature of the truck");
            base.print_info();
        }
    }

    public class Bus : Vehicle
    {
        public Bus(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
        }
        public override void print_info()
        {
            Console.WriteLine("Feature of the bus");
            base.print_info();
        }
    }

    public class Scooter : Vehicle
    {
        public Scooter(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
        }
        public override void print_info()
        {
            Console.WriteLine("Feature of the scooter");
            base.print_info();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Engine engine_car = new Engine(70, 1.8, "gasoline", "VS52626264");
            Chassis chassis_car = new Chassis(4, 700);
            Transmission transmission_car = new Transmission("auto", 5, "BMV");

            Engine engine_truck = new Engine(300, 5.8, "diesel", "VSGESRH578");
            Chassis chassis_truck = new Chassis(10, 8700);
            Transmission transmission_truck = new Transmission("mechanical", 6, "MAN");

            Engine engine_bus = new Engine(150, 2.8, "diesel", "VHDSJRTJR65");
            Chassis chassis_bus = new Chassis(6, 2500);
            Transmission transmission_bus = new Transmission("mechanical", 4, "VOLVO");

            Engine engine_scooter = new Engine(10, 0.8, "gasoline", "SGDSRTJR74");
            Chassis chassis_scooter = new Chassis(2, 150);
            Transmission transmission_scooter = new Transmission("mechanical", 3, "Suzuki");

            Car car = new Car(engine_car, chassis_car, transmission_car);
            Truck truck = new Truck(engine_truck, chassis_truck, transmission_truck);
            Bus bus = new Bus(engine_bus, chassis_bus, transmission_bus);
            Scooter scooter = new Scooter(engine_scooter, chassis_scooter, transmission_scooter);
                        
            car.print_info();
            Console.WriteLine();
            truck.print_info();
            Console.WriteLine();
            bus.print_info();
            Console.WriteLine();
            scooter.print_info();
        }
    }
}

