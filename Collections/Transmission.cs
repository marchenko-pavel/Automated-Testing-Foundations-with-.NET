
namespace Epam.Collections
{
    public class Transmission
    {
        public string Type;
        public int GearNumber;
        public string Vendor;

        public Transmission(string Type, int GearNumber, string Vendor)
        {
            this.Type = Type;
            this.GearNumber = GearNumber;
            this.Vendor = Vendor;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Type of transmission - {Type}");
            Console.WriteLine($"Number gear of transmission - {GearNumber}");
            Console.WriteLine($"Vendor of transmission - {Vendor}");
        }
    }

}
