using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Проверяет является введенная строка пользователем палиндромом или нет.
// Пробелы и регистр символов в строке игнорирует.
namespace _11409_MaximChernykh.PalindromNamespace
{
    internal class Palindrom
    {
        public void СheckPalindrom()
        {
            Console.WriteLine("Введите строку: ");
            string palindrom = Console.ReadLine();
            char[] withoutSpaces = palindrom.ToLower().ToCharArray();
            char[] revesePalindrom = palindrom.ToCharArray();

            for(int i = withoutSpaces.Length - 1; i > -1; i--)
            {
                revesePalindrom[withoutSpaces.Length - 1 - i] = withoutSpaces[i];
            }

            if ((new string(withoutSpaces)).Replace(" ", "") == (new string(revesePalindrom)).Replace(" ", ""))
            {
                Console.WriteLine(palindrom + " - это палиндром");
            }
            else
            {
                Console.WriteLine(palindrom + " - это не палиндром");
            }
        }
    }
}
