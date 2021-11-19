
namespace Epam.Collections
{
    public class Scooter : Vehicle
    {
        public Scooter(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Feature of the scooter");
            base.PrintInfo();
        }
    }
}
