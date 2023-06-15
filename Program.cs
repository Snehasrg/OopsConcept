namespace OopsConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Oops Concepts Problems");
            Console.WriteLine("Select any one option:- \n1.Object and Class Example." +
                              "\n2.Inheritance Example."+ "\n3.Polymorphism Example." +
                              "\n4.Encapsulation Example."+ "\n5.Abstraction Example.");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ObjectClass obj = new ObjectClass();
                    Console.WriteLine(obj.Name);
                    Console.WriteLine(obj.Colour);
                    break;
                case 2:
                    Car myCar = new Car();
                    myCar.honk();
                    Console.WriteLine(myCar.brand + " " + myCar.modelName);
                    break;
                case 3:
                    StaticPolymorphism polymorphism = new StaticPolymorphism();
                    polymorphism.Mult(4, 5);
                    polymorphism.Mult(6, 7.5f, 7);
                    polymorphism.Mult(3.3f, 6.6f);
                    Console.WriteLine("-------------------");
                    CarBrand obj2 = new CarBrand();
                    obj2.CarSound();
                    obj2 = new Hyundai();
                    obj2.CarSound();
                    obj2 = new BMW();
                    obj2.CarSound();
                    break;
                case 4:
                    Encapsulation encapsulation = new Encapsulation();
                    Console.WriteLine("Enter employee name");
                    encapsulation.Name = Console.ReadLine();
                    encapsulation.SetSalary(100000);
                    Console.WriteLine("Salary of " + encapsulation.Name + " is " + encapsulation.Salary);
                    break;
                case 5:
                    Cow cow = new Cow();
                    cow.Eat();
                    cow.AnimalSound();
                    break;
            }                         
        
        }
    }
}