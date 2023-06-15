using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Polymorphism
    {

    }
    //Static Polymorphism
    public class StaticPolymorphism
    {
        public void Mult(int a, int b)
        {
            Console.WriteLine("The multiplication of two number is " + a * b);
        }

        public void Mult(int a, float b, int c)
        {
            Console.WriteLine("The multiplication of three number is " + a * b * c);
        }

        public void Mult(float a, float b)
        {
            Console.WriteLine("The multiplication of two number is " + a * b);
        }
    }

    //Dynamic Polymorphism
    public class CarBrand
    {

        public virtual void CarSound()
        {
            Console.WriteLine("The Car sound tuu tuuu!");
        }
    }

    class Hyundai : CarBrand  // Derived class (child) 
    {
        public override void CarSound()
        {
            Console.WriteLine("The Hyundai Sounds Vrumm Vrumm!");
        }
    }

    class BMW : CarBrand  // Derived class (child) 
    {
        public override void CarSound()
        {
            Console.WriteLine("The BMW Sounds Broom Broom!");
        }
    }
}
