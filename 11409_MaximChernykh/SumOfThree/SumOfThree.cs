using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ищет количество чисел от 100 до 1000, которые равны N. Используются строки для решения
namespace _11409_MaximChernykh.SumOfThree
{
    internal class SumOfThree
    {
        public void Sum()
        {
            int N = int.Parse(Console.ReadLine());
            if (N < 0 || N > 27)
            {
                Console.WriteLine("Вне диапазона");
                return;
            }
            int sumOfNum = 0;
            string strNum = "";
            for (int i = 100; i < 1000; i++)
            {
                strNum = Convert.ToString(i);
                sumOfNum = strNum[0];
                Console.WriteLine(strNum);
            }
        }
    }
}
