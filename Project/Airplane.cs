using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Airplane:Airport
    {
        string name;
        string countplace;
        string flightrange;
        public Airplane(string name, string countplace, string flightrange)
        {
            this.name = name;
            this.countplace = countplace;
            this.flightrange = flightrange;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{name} {countplace} {flightrange}");
        }
    }
}
