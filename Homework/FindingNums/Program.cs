using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

// Ищет в строке цифры и выводит всё как единую строку
namespace Homework
{
    internal class FindingNums
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string stringWithNums = Console.ReadLine();
            string nums = "";

            for (int i = 0; i < 10;  i++)
            {
                foreach (char el in stringWithNums)
                {
                    if (el.ToString() == i.ToString())
                    {
                        nums = i.ToString() + nums;
                    }
                }
            }
            if (nums != "")
            {
                Console.WriteLine(nums);
            }
            else
            {
                Console.WriteLine("Не найдено цифр в строке");
            }
        }
    }
}
