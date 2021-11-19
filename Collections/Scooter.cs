
namespace Epam.Collections
{
    public class Scooter : Vehicle
    {
        public Scooter(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Feature of the scooter");
            base.PrintInfo();
        }
    }
}
