using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Inheritance
    {
        public void honk()
        {
            Console.WriteLine("Hyundai");
        }
    }
    //Single Inheritance
    class Car : Inheritance
    {
        public void honk2()
        {
            Console.WriteLine("Santro");
        }
    }
    //Hierarchical Inheritance
    class Bike : Inheritance
    {
        public void honk3()
        {
            Console.WriteLine("Royal Enfield");
        }
    }
    //Multilevel Inheritance
    class Car2 : Car
    {
        public void honk4()
        {
            Console.WriteLine("Aura");
        }
    }
}
