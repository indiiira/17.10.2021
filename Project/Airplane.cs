using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{ 

    public class Airplane
    {
        private string name;
        private string countplace;
        private string flightrange;
        public static List<Airplane> GetInfo()
        {
            using(StreamReader sr=new StreamReader("Airplane.txt"))
            {
                string str;
                var airplanes = new List<Airplane>();
                while ((str=sr.ReadLine())!=null)
                {
                    airplanes.Add(new Airplane(str.Split(' ')[0], str.Split(' ')[1], str.Split(' ')[2]));                  
                }
                foreach (var airplane in airplanes)
                {
                    airplane.PrintInfo();
                }
                return airplanes;
                
               
            }
            
        }


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
