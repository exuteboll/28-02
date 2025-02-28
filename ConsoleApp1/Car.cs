using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
         string brand;
         int years;
        public static int kolvo = 0;

        public string Brand { get { return brand; } set { brand = value; } }
        public int Years { get { return years; } set { years = value; } }

        public Car() { }
        public Car(string brand, int years)
        {
            this.Brand = brand;
            this.Years = years;
            
            kolvo++;
        }

        //public void ShowInfo()
        //{
        //    Console.WriteLine($"Бренд: {brand}\n Год: {years}\n Количество машин: {kolvo}");
        //}

    }
}
