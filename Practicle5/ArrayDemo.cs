using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicle5
{
    internal class ArrayDemo
    {
        int[] int_array= new int[5];

        public void getData()
        {
            Console.WriteLine("Enter array elements");
            for(int i=0; i<int_array.Length; i++) 
            {
                Console.Write($"Enter int_aray[{i}]:");
                int_array[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        public void PrintArray()
        {
            //foreach (int i in int_array)
            //{
            //    Console.WriteLine($"array members: {i}");

            //}
            try
            {
                Console.Write($"\narray indexes and elements are: ");
                for (int i = 0; i <=int_array.Length ; i++)
                {
                    Console.Write($"index:[{i}],element:{int_array[i]} ");
                       
                }
            }catch(IndexOutOfRangeException Ex)
            {
                Console.WriteLine("\n"+Ex.Message);
            }
            finally
            {
                Console.WriteLine("\nThis is finally block");
            }
        }
    }
}
