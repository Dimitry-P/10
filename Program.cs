using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    //•	Задача 10: Напишите программу, которая выводит количество цифр в числе.
    internal class Program
    {
        public static string num;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            num = Console.ReadLine();
            Console.WriteLine("Количество цифр: "+ num.Length);
        }
    }
}
