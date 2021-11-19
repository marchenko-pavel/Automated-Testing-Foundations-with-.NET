
namespace Epam.Collections
{
    public class Truck : Vehicle
    {
        public Truck(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Feature of the truck");
            base.PrintInfo();
        }
    }
}
