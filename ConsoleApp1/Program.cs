using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Brand = "Дигули";
            //car.Years = 2005;

            //car.ShowInfo();
            //Console.WriteLine("Введите марку бренд");
            //string brand1 = Console.ReadLine();
            //int years1 = int.Parse(Console.ReadLine());

            //Car car1 = new Car(brand1, years1);
            //car1.ShowInfo();
            //Car car2 = new Car("БМВ", 2000);
            //car2.ShowInfo();
            Car car12 = new Car("Жигули",25000);
            Car car13 = new Car("влопа", 214);
            Car car14 = new Car("asd", 124);
            Console.WriteLine($"{car12.Brand}{car12.Years},{Car.kolvo}");
            Console.ReadKey();
        }
    }
}
