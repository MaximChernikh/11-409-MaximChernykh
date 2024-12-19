using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Старая версия задачи SumOfThree со второй практики
// Проверяет сколько есть чисел от 100 до 1000, которые равны N
namespace Homework
{
    internal class CountOfThreeNums
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N < 1 && N > 27)
            {
                Console.WriteLine("Введите число в диапазоне от 1 до 27");
                return;
            }
            int count = 0;

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        if (i + j + l == N)
                        {
                            count += 1;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }

    }
}
