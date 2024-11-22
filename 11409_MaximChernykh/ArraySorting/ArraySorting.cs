using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Сортировка массива пузырьком *_*
namespace _11409_MaximChernykh.ArraySorting
{
    internal class ArraySorting
    {
        public int[] ArraySort()
        {
            Console.WriteLine("Введите размер массива: ");
            int[] N = new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введённый массив: ");
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write(N[i].ToString() + " ");
            }

            int temp = 0;
            for (int j = 0; j < N.Length - 1; j++)
            {
                for (int i = 0; i < N.Length - 1 - j; i++)
                {
                    if (N[i] > N[i + 1])
                    {
                        temp = N[i];
                        N[i] = N[i + 1];
                        N[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write(N[i].ToString() + " ");
            }
            return N;
        }
    }
}
