using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{

    class BuildInfo
    {
        private static Guid Identificator;
        private int height;
        private int floor;
        private int countflat;
        private int entrance;
        public BuildInfo GetInfo()
        {
            Console.WriteLine("Высота здания");

            while (!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Количество этажей");

            while (!int.TryParse(Console.ReadLine(), out floor))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Количество подъездов");

            while (!int.TryParse(Console.ReadLine(), out countflat))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            Console.WriteLine("Количество квартир");

            while (!int.TryParse(Console.ReadLine(), out entrance))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            var info = new BuildInfo();
            Identificator = Guid.NewGuid();

            return info;
        }
        public void Print()
        {

            Console.WriteLine("Информация о здании:");
            Console.WriteLine($"Id:{Identificator}");
            Console.WriteLine($"Высота:{height}");
            Console.WriteLine($"Этажи:{floor}");
            Console.WriteLine($"Количество квартир:{countflat}");
            Console.WriteLine($"Количество подъездов:{entrance}");
        }
        public void SolutionHeight()
        {
            int heightfloor = (int)(height / floor);
            Console.WriteLine($"Высота этажа:{heightfloor}");
        }
        public void SolutionCountFLat()
        {
            int CountFLat = (int)(entrance / countflat);
            Console.WriteLine($"Количество квартир в польезде:{CountFLat}");
        }
        public void SolutionCountFLatFloor(int cf)
        {
            int CountFLatFloor = (int)(cf / floor);
            Console.WriteLine($"Количество квартир на этаже:{ CountFLatFloor}");
        }
        class Program
        {
            static void Main(string[] args)
            {
                var build = new BuildInfo();
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Введите команды:заполнить, вывести, вычислить высоту этажа, вычислить количество квартир в подъезде, вычислить количество квартир на этаже, выход");

                    string act = Console.ReadLine().ToLower();
                    if (act.Equals("выход"))
                    {
                        flag = false;
                    }
                    else if (act.Equals("заполнить"))
                    {
                        build.GetInfo();
                    }
                    else if (act.Equals("вывести"))
                    {
                        build.Print();
                    }
                    else if (act.Equals("вычислить высоту этажа"))
                    {
                      


                        build.SolutionHeight();
                    }
                    else if (act.Equals("вычислить количество квартир в подъезде"))
                    {
                     


                        build.SolutionCountFLat();
                    }
                    else if (act.Equals("вычислить количество квартир на этаже"))
                    {
                        Console.WriteLine("Введите количество квартир на этаже");
                        int cf;
                        while (!int.TryParse(Console.ReadLine(), out cf) || cf < 0)
                        {
                            Console.WriteLine("Ошибка ввода! Введите целое число");
                        }

                        build.SolutionCountFLatFloor(cf);



                    }


                }
            }
        }
    }
}

