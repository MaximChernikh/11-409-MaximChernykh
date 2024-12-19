using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Переворачивает число
namespace Homework
{
    internal class ReversingNum
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Отрицательное число!");
                return;
            }

            int result = 0;
            while (a > 0)
            {
                result = result * 10;
                int b = a % 10;
                result += b;
                a /= 10;

            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
