namespace Practicle7
{
    internal class Program
    {
        enum options
        {
            SRP = 1,
            OCP,
            LSP,
            ISP,
            DIP
        }
        static void Main(string[] args)
        {
            int choice, amount;
            double discount = 0;
            string username = null;
            string password = null;
            string bdate = null;
            string gender=null;
            double? mobile=null;



            ValidateData srp = new ValidateData();


            while (true)
            {
                Console.WriteLine("\n===========");
                Console.WriteLine("1.SRP demo");
                Console.WriteLine("2.OCP demo");
                Console.WriteLine("3.LSP demo");
                Console.WriteLine("4.ISP demo");
                Console.WriteLine("5.DIP demo");
                Console.WriteLine("===========");
                Console.Write("Enter your Choice:");
                choice=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("===========");

                options ch = (options)choice;
                
                switch (ch)
                {
                    case options.SRP:
                        {
                            Console.Write("\nEnter username:");
                            username= Console.ReadLine();
                            Console.Write("\nEnter password:");
                            password= Console.ReadLine();
                            if(srp.validate_info(username, password))
                            {
                                Console.WriteLine("Login sucess");
                            }
                            else
                            {
                                Console.WriteLine("Login failed");
                            }
                            break;
                        }
                    case options.OCP:
                        {
                            Console.WriteLine("Enter Amount of Invoice:");
                            amount= Convert.ToInt32(Console.ReadLine());
                            if(amount<10000)
                            {
                                FinalInvoice finalInvoice = new FinalInvoice();
                                discount = finalInvoice.GetInvoiceDiscount(amount);
                                Console.WriteLine($"final discount = {amount-discount}");
                                
                            }else if(amount>=10000)
                            {

                                ProposedInvoice proposedInvoice = new ProposedInvoice();
                                discount= proposedInvoice.GetInvoiceDiscount(amount);
                                Console.WriteLine($"final discount = {amount-discount}");
                            }
                            Console.WriteLine($"final Amount Paid:{discount}");
                            break;
                        }
                    case options.LSP:
                        {
                            
                            IFood food = new Pitza();
                            Console.WriteLine("\n-------------------------------------------------------------------------");
                            Console.WriteLine("IFood food = new pitza();");
                            Console.WriteLine($"pitza class ingredients method food.Food_ing();:-> {food.Food_ing()}");
                            Console.WriteLine($"pitza class origin method food.Food_origin();:->{food.Food_origin()}");
                            Console.WriteLine($"pitza class food type method food.Food_type();:->{food.Food_type()}");
                            
                            
                            food = new PavBhaji();
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine($"\nfood = new PavBhaji(); ");
                            Console.WriteLine($"PavBhaji class ingredients method food.Food_ing();:-> {food.Food_ing()}");
                            Console.WriteLine($"PavBhaji class origin method food.Food_origin();:->{food.Food_origin()}");
                            Console.WriteLine($"PavBhaji class food type method food.Food_type();:->{food.Food_type()}");
                            
                            
                            food = new PaniPuri();
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.WriteLine($"\nfood = new panipuri(); ");
                            Console.WriteLine($"PaniPuri class ingredients method food.Food_ing();:-> {food.Food_ing()}");
                            Console.WriteLine($"PaniPuri class origin method food.Food_origin();:->{food.Food_origin()}");
                            Console.WriteLine($"PaniPuri class food type method food.Food_type();:->{food.Food_type()}");
                            break;
                        }
                    case options.ISP:
                        {
                            //Using HPLaserJetPrinter we can access all Printer Services
                            Console.WriteLine("\n-------------------------------------------------------------------------");
                            Console.WriteLine("HPLaserJetPrinter implemets all interfaces.");
                            HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
                            hPLaserJetPrinter.Print("Printing");
                            hPLaserJetPrinter.Scan("Scanning");
                            hPLaserJetPrinter.Fax("Faxing");
                            hPLaserJetPrinter.PrintDuplex("PrintDuplex");
                            //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
                            Console.WriteLine("\n-------------------------------------------------------------------------");
                            Console.WriteLine("LiquidInkjetPrinter implements only Access Print and Scan Printer interface.");
                            LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
                            liquidInkjetPrinter.Print("Printing");
                            liquidInkjetPrinter.Scan("Scanning");
                            break;
                        }
                    case options.DIP:
                        {
                            
                            Student std1 = new Student(RepositoryFactory.GetStudentRepository());
                            std1.Save();
                            break;
                        }
                }
            }
            
        }
    }
}