using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace practicle2
{
    internal class CustomerAccount
    {
        readonly string bank_name;
        string customer_name;
        long customer_accountNo;
        public CustomerAccount(string cust_name,long cust_accNo)
        {
            bank_name = "DCB BANK";
            customer_accountNo = cust_accNo;
            customer_name = cust_name;
        }

        //printInfo() method declare for display the passbook of user.
        //method not take any parameter also not have returntype.
            public void PrintInfo()
        {
            Console.WriteLine("=======================");
            Console.WriteLine($"WELCOME TO {bank_name}");
            Console.WriteLine("=======================");
            Console.WriteLine("=======Pass-Book=========\n");
                
            Console.WriteLine($"Customer Name: {customer_name}\n");
            Console.WriteLine($"AccountNo: {customer_accountNo}\n");
            
            Console.WriteLine("=========================");
        }
    }
}
