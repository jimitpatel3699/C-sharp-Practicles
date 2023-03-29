using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicle1
{
    internal class Calculator
    {
        
        public void Calculation()
        {
            Console.Write("Enter first number:");
            int no1 = Convert.ToInt32(Console.ReadLine());
            number2:
            Console.Write("\nEnter second number:");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nThe sum of the {no1} and {no2} is {no1 + no2}");
            Console.WriteLine($"\nThe subtraction of the {no1} and {no2} is {no1 - no2}");
            Console.WriteLine($"\nThe multiplication of the {no1} and {no2} is {no1 * no2}");
            try
            {
                Console.WriteLine($"\nThe division of the {no1} and {no2} is {no1 / no2}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nDivided by 0 is not possible\n");
                goto number2;
            }

        }
          
        
    }
}
