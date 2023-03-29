using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Practicle4
{
    internal class Student
    {
        //declaring variables of student class
        public string Name;
        public decimal[] Marks = new decimal[5];
        public static decimal AverageMarks;
        public string grade;
        public Student(string name)
        {
            Name = name;
        }

        //create enum for perform switch case operations
        enum Options
        {
            Aggregate = 1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4

        }
        
        //getmarks() method for taking student marks[5]
        public void getmarks()
        {
            Console.WriteLine($"Enter Marks of {Name}");
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.Write($"Enter Marks[{i + 1}]:");
                Marks[i] = Convert.ToDecimal(Console.ReadLine());
                
            }
        }
        //CalculateAverageMarks() calculare average of student and return the average.
        public decimal CalculateAverageMarks()
        {
       
            AverageMarks = Marks.Average();
            return AverageMarks;
        }

        //CalculateGrade() to calculate grade and returen it take student average marks as a parameter.
        public string CalculateGrade(decimal marks)
        {
            if (marks >= 90)
            {
                grade = "A";
            }
            else if(marks >= 80)
            {
                grade="B";
            }
            else if(marks>=70)
            {
                grade="C";
            }
            else if(marks<70)
            {
                grade="D";
            }

            return grade;
        }

        //Opetions()is the method which one calling by object after the student marks getting..
        public void Opetions()
        {
            while (true)
            {
                Console.WriteLine("====================");
                Console.WriteLine("Enter your choice based on options:\n");
                Console.WriteLine("1.Aggregate");
                Console.WriteLine("2.View Minimum Marks");
                Console.WriteLine("3.View Maximum Marks");
                Console.WriteLine("4.View Grade");
                Console.WriteLine("====================");
                Console.Write("Enter your choice:");   
                int choice = Convert.ToInt32(Console.ReadLine());
                Options choice1 = (Options)choice;
                Console.WriteLine("====================\n");

                //switch pattern matching statement.

                Console.WriteLine(choice1 switch
                {
                    Options.Aggregate => $"Student= {Name}\n Aggregate= {CalculateAverageMarks()}",
                    Options.MinMark => $"Minimum marks= {Marks.Min()}",
                    Options.MaximumMark => $"Maxium marks= {Marks.Max()}",
                    Options.Grade => $"{Name} Grade:{CalculateGrade(AverageMarks)}",
                    _ => "Invalid input!",
                });
                
            }
        }
           
    }
}


