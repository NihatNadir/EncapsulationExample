using System;
namespace EncapsulationExample
{
    class Program
    {
        public static void Main(string[] args)
        {
           

            Araba newCar1 = new Araba();
            Console.WriteLine("Default Constructor ile oluşturulan boş nesne");
            newCar1.TellInfo();

            Console.WriteLine("----------------------------------------");

            Araba newCar2 = new Araba();
            Console.WriteLine("\nDefault Constructor ile oluşturulan 3 kapılı nesne");
            newCar2.Brand = "";
            newCar2.Model = "";
            newCar2.Color = "";
            newCar2.DoorCount = 3;
            newCar2.TellInfo();

            Console.WriteLine("----------------------------------------");

            Araba newCar3 = new Araba();
            Console.WriteLine("\nDefault Constructor ile oluşturulan 2 kapılı nesne");
            newCar3.Brand = "Nissan";
            newCar3.Model = "Juke";
            newCar3.Color = "Gri";
            newCar3.DoorCount = 2;
            newCar3.TellInfo();

            Console.WriteLine("----------------------------------------");

            Araba newCar4 = new Araba();
            Console.WriteLine("\nDefault Constructor ile oluşturulan 4 kapılı nesne");
            newCar4.Brand = "Kia";
            newCar4.Model = "Sportage";
            newCar4.Color = "Siyah";
            newCar4.DoorCount = 4;
            newCar4.TellInfo();

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nParametre alan Constructor ile oluşturulan 3 kapılı nesne");
            Araba newCar5 = new Araba("", "", "", 3);            
            newCar5.TellInfo();

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nParametre alan Constructor ile oluşturulan 2 kapılı nesne");
            Araba newCar6 = new Araba("Peugeot","RCZ","Siyah",2);            
            newCar6.TellInfo();

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nParametre alan Constructor ile oluşturulan 4 kapılı nesne");
            Araba newCar7 = new Araba("Togg", "T10X", "Kırmızı", 4);
            newCar7.TellInfo();
        }
    }
}