
namespace Epam.OOP
{
    public class Bus : Vehicle
    {
        public Bus(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Feature of the bus");
            base.PrintInfo();
        }
    }
}
