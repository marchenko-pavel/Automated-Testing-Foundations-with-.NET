using System;
using System.Linq;
using System.Xml.Linq;

namespace Epam.Collections
{
    class Program
    {
        static void Main(string[] args)
        {            
            // создание экземпляров транспортных средств
            Vehicle Car = new Car("BMV_Car", new Engine(70, 1.8, "gasoline", "VS52626264"), 
                new Chassis(4, 700), new Transmission("auto", 5, "BMV"));
            Vehicle Car2 = new Car("ВАЗ_Car", new Engine(60, 1.4, "gasoline", "SLGSELR454"),
                new Chassis(4, 500), new Transmission("mechanical", 4, "ВАЗ"));
            Vehicle Truck = new Truck("MAN_Truck", new Engine(300, 5.8, "diesel", "VSGESRH578"),
                new Chassis(10, 8700), new Transmission("mechanical", 6, "MAN"));
            Vehicle Truck2 = new Truck("VOLVO_Truck", new Engine(400, 5.6, "gasoline", "FSLEHG6789"),
                new Chassis(8, 7500), new Transmission("avto", 5, "VOLVO"));
            Vehicle Bus = new Bus("VOLVO_Bus", new Engine(150, 2.8, "diesel", "VHDSJRTJR65"),
                new Chassis(6, 2500), new Transmission("mechanical", 4, "VOLVO"));
            Vehicle Bus2 = new Bus("Nissan_Bus", new Engine(120, 1.8, "gasoline", "KJHKF78580"),
                new Chassis(4, 1500), new Transmission("avto", 5, "Nissan"));
            Vehicle Scooter = new Scooter("Suzuki_Scooter", new Engine(10, 0.8, "gasoline", "SGDSRTJR74"),
                new Chassis(2, 150), new Transmission("mechanical", 3, "Suzuki"));
            Vehicle Scooter2 = new Scooter("Xiaomi_Scooter", new Engine(12, 1.1, "gasoline", "LKHG89669"),
                new Chassis(2, 160), new Transmission("mechanical", 4, "Xiaomi"));

            // добавление транспортных средств в коллекцию
            List<Vehicle> VehiclesCollection = new List<Vehicle>();
            VehiclesCollection.Add(Car);
            VehiclesCollection.Add(Car2);
            VehiclesCollection.Add(Truck);
            VehiclesCollection.Add(Truck2);
            VehiclesCollection.Add(Bus);
            VehiclesCollection.Add(Bus2);
            VehiclesCollection.Add(Scooter);
            VehiclesCollection.Add(Scooter2);

            // создание запроса Linq для выбора транспортных средств с объемом более 1.5
            var selectedVolumeEngine = from Vehicle in VehiclesCollection
                                 where Vehicle.Engine.Volume > 1.5
                                 select Vehicle;

            // создание xml документа на основе запроса selectedVolumeEngine и запись его в файл
            XDocument xdocSelectedVihiclesVolume = new XDocument(
                            new XDeclaration("1.0", "utf-8", "yes"),
                            new XComment("Create Xml - Sellect vehicale by volume more than 1.5"),
                            new XElement("Vihicles",                                
                                from vehicle in selectedVolumeEngine
                                select
                                new XElement("Vehicle", vehicle.name,
                                        new XElement("Engine_Power", vehicle.Engine.Power),
                                        new XElement("Engine_Volume", vehicle.Engine.Volume),
                                        new XElement("Engine_Type", vehicle.Engine.Type),
                                        new XElement("Engine_SerialNumber", vehicle.Engine.SerialNumber),
                                        new XElement("ChassisWheels", vehicle.Chassis.Wheels),
                                        new XElement("ChassisWorkload", vehicle.Chassis.Workload),
                                        new XElement("Transmission_Type", vehicle.Transmission.Type),
                                        new XElement("Transmission_GearNumber", vehicle.Transmission.GearNumber),
                                        new XElement("Transmission_Vendor", vehicle.Transmission.Vendor))));
            xdocSelectedVihiclesVolume.Save("SelectedVihiclesVolume.xml");

            // создание запроса Linq для выбора авбобусов и грузовиков
            var selectedBusTruck = from Vehicle in VehiclesCollection
                                   where Vehicle.GetType().Name == "Bus" || Vehicle.GetType().Name == "Truck"
                                   select Vehicle;

            // создание xml документа на основе запроса selectedBusTruck и запись его в файл
            XDocument xdocselectedBusTruck = new XDocument(
                            new XDeclaration("1.0", "utf-8", "yes"),
                            new XComment("Create Xml - Sellect Bus and Truck"),
                            new XElement("Vihicles",
                                from vehicle in selectedBusTruck
                                select
                                new XElement("Vehicle", vehicle.name,
                                        new XElement("Engine_Power", vehicle.Engine.Power),
                                        new XElement("Engine_Volume", vehicle.Engine.Volume),
                                        new XElement("Engine_Type", vehicle.Engine.Type),
                                        new XElement("Engine_SerialNumber", vehicle.Engine.SerialNumber))));
            xdocselectedBusTruck.Save("SelectedBusTruck.xml");

            // создание запроса Linq для группировки транспортных средств по типу трансмиссии
            var soltedTypeTransmission = from Vehicle in VehiclesCollection
                                       orderby Vehicle.Transmission.Type
                                       select Vehicle;

            // создание xml документа на основе запроса soltedTypeTransmission и запись его в файл
            XDocument xdocSoltedTypeTransmission = new XDocument(
                            new XDeclaration("1.0", "utf-8", "yes"),
                            new XComment("Create Xml - Sorted vihicle by type transmission"),
                            new XElement("Vihicles",
                                from vehicle in soltedTypeTransmission
                                select
                                new XElement("Vehicle", vehicle.name,
                                        new XElement("Engine_Power", vehicle.Engine.Power),
                                        new XElement("Engine_Volume", vehicle.Engine.Volume),
                                        new XElement("Engine_Type", vehicle.Engine.Type),
                                        new XElement("Engine_SerialNumber", vehicle.Engine.SerialNumber),
                                        new XElement("ChassisWheels", vehicle.Chassis.Wheels),
                                        new XElement("ChassisWorkload", vehicle.Chassis.Workload),
                                        new XElement("Transmission_Type", vehicle.Transmission.Type),
                                        new XElement("Transmission_GearNumber", vehicle.Transmission.GearNumber),
                                        new XElement("Transmission_Vendor", vehicle.Transmission.Vendor))));
            xdocSoltedTypeTransmission.Save("SoltedTypeTransmission.xml");
        }
    }
}

