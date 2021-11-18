
namespace Epam.OOP
{
    public class Car : Vehicle
    {
        public Car(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Feature of passenger the car");
            base.PrintInfo();
        }
    }
}
