using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;



namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new StreamReader("InfoStudents.txt");
            var airplane = new List<Airplane>(3); 
            int countOfAirplane = 0;
            while (file.ReadLine() != null)
            {
                countOfAirplane++;
            }
            file = new StreamReader("Airplane.txt");
            for (int i = 1; i <= countOfAirplane; i++)
            {
                string[] tempLine = file.ReadLine().Split();
                string name = tempLine[0];
                string countplace = tempLine[1];
                string flightrange = tempLine[2];
                
               airplane.Add(new Airplane(name, countplace, flightrange));
            }
           Airplane.Pr


        }
    }
}
