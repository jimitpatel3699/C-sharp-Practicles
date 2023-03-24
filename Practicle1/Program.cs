namespace Practicle1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calsi = new Calculator();
            DebuggingApplication dbug = new DebuggingApplication();
            int choice;
            while (true)
            {
                Console.WriteLine("============================");
                Console.WriteLine("\nEnter 1 for Calculator app");
                Console.WriteLine("Enter 2 for Debugging app");
                Console.WriteLine("Enter 0 for close Window");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("============================");
                switch (choice)
                {
                    case 1:
                        {
                            
                            calsi.Calculation();
                            break;
                        }
                    case 2:
                        {
                            dbug.Method_debug();
                            break;
                        }
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
                
            }
            
        }
    }
}