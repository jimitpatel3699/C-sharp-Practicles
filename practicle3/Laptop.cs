using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicle3
{
    internal class Laptop
    {
        private string _brand;
        private string _model;

        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        
     
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);

            Console.WriteLine("Model: " + Model);
        }
        public void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
