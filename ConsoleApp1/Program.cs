using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            nachalo();
           
           

        }

        static void ugadai()
        {
            Console.WriteLine("Введите чилсо от 1 до 100");
            Random random = new Random();
            int a = random.Next(1, 100);


            int b = Convert.ToInt32(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                {
                    Console.WriteLine("Больше нада");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                else if (a < b)
                {
                    Console.WriteLine("Меньше нада");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                else if (a == b)
                {
                    Console.WriteLine("Угадал \n");
                }


            }
            Console.WriteLine("Угадал \n");
            nachalo();
        }
        static void nachalo()
        {
            Console.WriteLine("Введите номер программы которую хотите запустить");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть консоль ");
            int gachi = Convert.ToInt32(Console.ReadLine());
            if (gachi == 1)
            {
                ugadai();
            }
            else if (gachi == 2)
            {
                tablicaumnojenia();
            }
            else if (gachi == 3)
            {
                delitelichisla();
            }
            else if (gachi == 4)
            {
                Console.Clear();
            }

        }
       static void tablicaumnojenia()
        {
            int[,] tablica = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    tablica[i, j] = i * j;
                }
                Console.WriteLine(" ");
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            nachalo();
        }
        static void delitelichisla()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            for    (int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
            nachalo();
        }

    }
}
