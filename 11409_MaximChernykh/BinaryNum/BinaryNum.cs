using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Перевод числа десятичной системы в двоичную с использованием массива
namespace _11409_MaximChernykh.BinaryNum
{
    internal class BinaryNum
    {
        public void toBinaryNum(string[] args)
        {
            {
                int N = int.Parse(Console.ReadLine());
                if (N < 0)
                {
                    Console.WriteLine("Отрицательное число!");
                    return;
                }
                string result = "";
                while (N > 0)
                {
                    result = result + (N % 2).ToString();
                    N = N / 2;
                }
                Console.WriteLine(result.Reverse().ToArray());
            }
        }
    }
}
