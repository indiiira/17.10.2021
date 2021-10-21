using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    enum AccountType
    { 
    Actual=1, 
    Savings
    }

    class Bank
    {
        private static Guid Identificator;
        private decimal Balance;
        private AccountType Type;

        public Bank GetInfo()
        {
            Console.WriteLine("Номер счета 1 или 2");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }

            Console.WriteLine("Введите баланс");
            while (!decimal.TryParse(Console.ReadLine(), out Balance) || Balance < 0)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            var bank = new Bank();
            Identificator = Guid.NewGuid();
            Type = (AccountType)(n);
            return bank;

        }
        public void Print()
        {

            Console.WriteLine("Информация о счете:");
            Console.WriteLine($"Id:{Identificator}");
            Console.WriteLine($"Balance:{Balance}");
            Console.WriteLine($"Account type:{Type}");

        }
        public void CheckOut(decimal output)
        {   
            if (Balance>output)
            {
                Balance -= output;
            }
            else
            {
                Console.WriteLine("Недостаточно денег для снятия");
            }
        }
        public void CheckBalance(decimal input)
        {
            Balance += input;     
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 7.1,2,3");
            var bankinfo = new Bank();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите команды:заполнить, вывести, снять со счета, положить на счет, выход");

                string act = Console.ReadLine().ToLower();
                if (act.Equals("выход"))
                {
                    flag = false;
                }
                else if (act.Equals("заполнить"))
                {
                    bankinfo.GetInfo();
                }
                else if (act.Equals("вывести"))
                {
                    bankinfo.Print();
                }
                else if (act.Equals("снять со счета"))
                {
                    decimal output;
                    Console.WriteLine("Сумма для снятия");
                    while (!decimal.TryParse(Console.ReadLine(), out output) || output < 0)
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число n");
                    }
                    bankinfo.CheckOut(output);
                }
                else if (act.Equals("положить на счет"))
                {
                    decimal input;
                    Console.WriteLine("Сумма для пополнения");
                    while (!decimal.TryParse(Console.ReadLine(), out input) || input < 0)
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число n");
                    }
                    bankinfo.CheckBalance(input);
                }
                Console.ReadKey();
            }


        }
    }
}
