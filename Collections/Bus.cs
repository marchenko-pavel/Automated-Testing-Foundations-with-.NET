
namespace Epam.Collections
{
    public class Bus : Vehicle
    {
        public Bus(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Feature of the bus");
            base.PrintInfo();
        }
    }
}
