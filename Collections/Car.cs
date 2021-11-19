
namespace Epam.Collections
{
    public class Car : Vehicle
    {
        public Car(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Feature of passenger the car");
            base.PrintInfo();
        }
    }
}
