using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            int n = int.Parse(Console.ReadLine());

            byte d1 = (byte)(n / 1000);          // тысячи
            byte d2 = (byte)(n / 100 % 10);      // сотни
            byte d3 = (byte)(n / 10 % 10);       // десятки
            byte d4 = (byte)(n % 10);            // единицы

            Console.WriteLine($"Тысячи: {d1}");
            Console.WriteLine($"Сотни: {d2}");
            Console.WriteLine($"Десятки: {d3}");
            Console.WriteLine($"Единицы: {d4}");
        }
    }
}