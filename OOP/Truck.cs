
namespace Epam.OOP
{
    public class Truck : Vehicle
    {
        public Truck(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Feature of the truck");
            base.PrintInfo();
        }
    }
}
