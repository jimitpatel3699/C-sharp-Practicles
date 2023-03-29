using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practicle3
{
    //create class for perform demo of inheritance
    internal class Team:Sponsor
    {
        private string _teamName;

        //public ConstructorBuilder intialize the teamname
        public Team(string teamName)
        {
            _teamName = teamName;
        }

        //PrintInfo() method which is Concurent _teamname and owner var and return that.

        public string printInfo()
        {
            string team1 = "team owner: "+owner +"  team name:"+ _teamName;
            return team1;
        }
    }
}
