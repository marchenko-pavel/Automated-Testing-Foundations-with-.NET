
namespace Epam.OOP
{
    public class Engine
    {
        protected int Power;
        protected double Volume;
        protected string Type;
        protected string SerialNumber;

        public Engine(int Power, double Volume, string Type, string SerialNumber)
        {
            this.Power = Power;
            this.Volume = Volume;
            this.Type = Type;
            this.SerialNumber = SerialNumber;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Power of engine - {Power}");
            Console.WriteLine($"Volume of engine - {Volume}");
            Console.WriteLine($"Type of engine - {Type}");
            Console.WriteLine($"Serial number - {SerialNumber}");
        }
    }
}
