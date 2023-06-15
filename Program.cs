namespace OopsConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Oops Concepts Problems");
            Console.WriteLine("Select any one option:- \n1.Object and Class Example." +
                              "\n2.Inheritance Example.");

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
            }                         
        
        }
    }
}