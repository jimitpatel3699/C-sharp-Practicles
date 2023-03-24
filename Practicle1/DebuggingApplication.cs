using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicle1
{
    internal class DebuggingApplication
    {
        public void Method_debug()
        {
            string userResponse;
            Console.WriteLine("Enter string:");
            userResponse= Console.ReadLine();
            try
            {
                if (Convert.ToBoolean(int.Parse(userResponse)))
                {

                    Console.WriteLine("The entered value is a integer");

                }
            }catch(FormatException EX)
            {
                Console.WriteLine(EX.Message);
            }
           
          


        }
    }
}
