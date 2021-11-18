
namespace Epam.OOP
{
    public class Chassis
    {
        protected int Wheels;
        protected int Workload;

        public Chassis(int Wheels, int Workload)
        {
            this.Wheels = Wheels;
            this.Workload = Workload;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Wheels of chassis - {Wheels}");
            Console.WriteLine($"Workload of chassis - {Workload}");
        }
    }

}
