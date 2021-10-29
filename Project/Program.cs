using System;
using System.Linq;
using System.Collections.Generic;



namespace Project
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("До");
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("Выберите команду : <пойти в duty free> <пойти на кассу> <посмотреть> информацию о самолетах, <выйти>");
                string str = Console.ReadLine();

                if (Equals(str, "пойти на кассу"))
                {
                    Console.WriteLine("вы пришли на кассу, выберите действие : <посмотреть> рейсы, <выбрать> билет, выйти");

                    bool flag1 = true;
                    while (flag1)
                    {
                        string str1 = Console.ReadLine();
                        if (Equals(str1, "посмотреть"))
                        {
                            Flight.GetInfo();
                        }
                        if (Equals(str1, "выбрать"))
                        {
                            
                            Console.WriteLine("Выберите город в который хотите полететь-->");
                            string c = Console.ReadLine();
                            Flight.Choose(c);
                            
                        }
                        else if (Equals(str1, "выйти"))
                        {
                            flag1=false;
                        }
                    }

                }
            
                else if (Equals(str, "посмотреть"))
                {
                    Airplane.GetInfo();
                }
                
                else if (Equals(str, "выйти"))
                {
                    flag = false;
                }
                else if (Equals(str, "пойти в duty free"))
                {
                    bool flag2 = true;
                    List<string> korzina = new List<string>();
                    Console.WriteLine("выберите действие : <меню>, <выбрать> товар,<оплатить>, <выйти>");
                    while (flag2)
                    {
                        string str2 = Console.ReadLine();
                        if (Equals(str2, "меню"))
                        {
                            Duty.GetInfo();
                        }
                        else if (Equals(str2, "выбрать"))
                        {


                            Console.WriteLine("Что хотите приобрести? Если вы закончили, скажите <все>");
                            bool flag3=true;
                            while (flag3)
                            {
                                string order = Console.ReadLine();
                                if (!Equals(order, "все"))
                                {
                                    korzina.Add(order);
                                   
                                    Console.WriteLine("Корзина");
                                    foreach (var i in korzina)
                                    {
                               
                                        Console.WriteLine(i);
                                    }
                                }
                                else if (Equals(order, "все"))
                                {
                                    flag3 = false;
                                }

                            }
                        }

                        else if (Equals(str2, "оплатить"))
                        {
                            Console.WriteLine("Товары успешно оплачены!");
                    
                        }

                        else if (Equals(str2, "выйти"))
                        {
                            flag2 = false;
                        }
                   }
                 }
              }

         }
      }

 }


    

