using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Сортирует две строки и сравнивает их, чтобы узнать могут ли слова быть анагаммами
namespace Homework
{
    internal class Anagramma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строки: ");
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            string firstSortedWord = string.Concat(firstWord.OrderBy(x => x).ToArray());
            string secondSortedWord = string.Concat(secondWord.OrderBy(x => x).ToArray());

            if (firstSortedWord == secondSortedWord)
            {
                Console.WriteLine(firstWord + " и " + secondWord + " - анаграмма");
            }
            else
            {
                Console.WriteLine(firstWord + " и " + secondWord + " - не анаграмма");
            }
        }
    }
}
