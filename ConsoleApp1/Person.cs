using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private int age;
        private int retirementAge = 65;
        public Person() { }
        public Person(int age)
        {
            this.age = age;
          
        }

        public int RetirementAge {
            get
            { return retirementAge; }
            set { if (value > 1 && value < 100) retirementAge = value; }
        }


        public void CheckAge()
        {
            if (age >= RetirementAge)
            { Console.WriteLine("подходит"); }
            else
            {
                Console.WriteLine($"не подходит до пенсии {retirementAge - age}");
            }


        }
    }
}

