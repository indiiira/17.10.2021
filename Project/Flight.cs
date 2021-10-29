using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    public class Flight 
    {
        private string id;
        private string airportname;
        private string city;
        private string hours;
        
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Airportname
        {
            get { return airportname; }
            set { airportname = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public Flight(string id, string airportname, string city, string hours)
        {
            this.id = id;
            this.airportname = airportname;
            this.city = city;
            this.hours = hours;
        }
        
        public static List<Flight> GetInfo()
        {
            List<Flight> flights = new List<Flight>();
            int count = 0;
            using  (StreamReader sr = new StreamReader("Flight.txt")) 
            {                         
                while (sr.ReadLine()!= null)
                {
                    count++;
                }
                
                sr.Close();
            }
            using (StreamReader sr1 = new StreamReader("Flight.txt"))
            {
                for (int i = 0; i < count; i++)
                {
                    string str = sr1.ReadLine();
                    flights.Add(new Flight(str.Split(' ')[0], str.Split(' ')[1], str.Split(' ')[2], str.Split(' ')[3]));
                }
                foreach (var m in flights)
                {
                    m.PrintInfo();
                }
            }
           return flights; 
        }
        public static void Choose(string city)
        {
            var flights = GetInfo();
            bool isFounded = false;
            foreach (var fly in flights)
            {
              if (fly.city.Equals(city))
                {
                    isFounded = true;
                    Console.WriteLine($"билет до {city} оформлен");
                }
            
            if (!isFounded)
            {
                Console.WriteLine("Билет не был найден");
            }
        }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{id} {airportname} {city}, {hours}");
        }
    }
}
