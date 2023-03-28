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
                            break;
                        }
                    case options.ISP:
                        {
                            break;
                        }
                    case options.DIP:
                        {
                            break;
                        }
                }
            }
            
        }
    }
}