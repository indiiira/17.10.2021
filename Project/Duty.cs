using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class Duty

    {
        public Duty(string name, string price)
        {
            this.name = name;
            this.price = price;
        }
        private string name;
        private string price;
        public static List<Duty> GetInfo()
        {
            using (StreamReader sr = new StreamReader("Price.txt"))
            {
                string str;
                var menu = new List<Duty>();
                while ((str = sr.ReadLine()) != null)
                {
                    menu.Add(new Duty(str.Split(' ')[0], str.Split(' ')[1]));
                }
                foreach (var m in menu)
                {
                    m.PrintInfo();
                }
                return menu;


            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name} {price}");
        }
    }

}
