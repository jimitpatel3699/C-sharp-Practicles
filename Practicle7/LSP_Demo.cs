using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicle7
{
    //create one interface IFood which is parent for all available classes and which is ensure derived class replace it.
    interface IFood
    {
        string Food_type();
        string Food_ing();
        string Food_origin();
        
    }
    internal class Pitza : IFood
    {
        public string Food_type()
        {
            return "fastfood";
        }

        public string Food_ing()
        {
            return "pitzabase,cheese,sauce...";
        }

        public string Food_origin()
        {
            return "itely";
        }
    }


    internal class PavBhaji : IFood
    {
        public string Food_ing()
        {
            return "pav,bhaji,butter...";
        }

        public string Food_origin()
        {
            return "india";
        }

        public string Food_type()
        {
            return "fastfood";
        }
    }

    internal class PaniPuri : IFood
    {
        public string Food_ing()
        {
            return "patato,puri,beans,water...";
        }

        public string Food_origin()
        {
            return "india";
        }

        public string Food_type()
        {
            return "fastfood";
        }
    }

   
}
