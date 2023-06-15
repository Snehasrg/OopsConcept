using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void Eat()
        {
            Console.WriteLine("Animal eats Grass");
        }
    }
    class Cow : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cow Sleeps");
        }
    }
}
