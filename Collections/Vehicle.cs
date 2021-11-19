
namespace Epam.Collections
{
    public class Vehicle
    {
        protected Engine Engine;
        protected Chassis Chassis;
        protected Transmission Transmission;

        public Vehicle(Engine Engine, Chassis Chassis, Transmission Transmission)
        {
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
