
namespace Epam.Collections
{
    public class Vehicle
    {
        public string name;
        public Engine Engine;
        public Chassis Chassis;
        public Transmission Transmission;

        public Vehicle(string name, Engine Engine, Chassis Chassis, Transmission Transmission)
        {
            this.name = name;
            this.Engine = Engine;
            this.Chassis = Chassis;
            this.Transmission = Transmission;
        }

        public virtual void PrintInfo()
        {
            Engine.PrintInfo();
            Chassis.PrintInfo();
            Transmission.PrintInfo();
        }
    }

}
