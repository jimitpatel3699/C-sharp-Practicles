using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicle3
{
    //create class which is extend Bird class for demo of polymorphism.
    internal class Duck : Bird
    {
        public void Voice()
        {
            Console.WriteLine("Quac Quac");
        }
    }
}
