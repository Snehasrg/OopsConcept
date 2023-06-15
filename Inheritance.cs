using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Inheritance
    {
        public string brand = "Hyundai";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Inheritance
    {
        public string modelName = "Santro";
    }
}
