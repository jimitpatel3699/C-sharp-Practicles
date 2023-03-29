namespace practicle3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance Demo
            Console.WriteLine("\nInheritance Demo\n");
            Console.WriteLine("=====================");
            Team tm1 = new Team("CSK");
            string team_owner = tm1.printInfo();
            Console.WriteLine($"{team_owner}");
            Console.WriteLine("=====================");

            //Polymorphism Demo
            Console.WriteLine("\nPolymorphism Demo\n");
            Console.WriteLine("=====================");
            Bird myBird = new Bird();
            Console.WriteLine("Bird is base(parent) class & Duck is a derived(child) class");
            Console.WriteLine("Bird myBird = new Bird(); is possible create object of parent class using parent class");
            Console.WriteLine("Duck myDuck = new Bird(); is not possible because create object of base class through parent class not possible.");
            Console.WriteLine("Bird myBird = new Duck(); This is possible making refrence object of parent class through child class");
            //Duck myDuck = new Bird();
            Console.WriteLine("=====================");

            //Abstraction Demo
            Console.WriteLine("\nAbstraction Demo\n");
            Console.WriteLine("=====================");
            Laptop laptop = new Laptop();

            //set value of private memeber by using property and events.
            laptop.Brand = "Lenovo";
            laptop.Model = "Thinpad";
            laptop.LaptopDetails();
            laptop.MotherBoardInfo();
            Console.WriteLine("=====================");
        }
    }
}