using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11409_MaximChernykh.FindingNumsNamespace;
using _11409_MaximChernykh.CapitalizingTextNamespace;
using _11409_MaximChernykh.PalindromNamespace;
using _11409_MaximChernykh.AnagrammaNamespace;
using _11409_MaximChernykh.SubstringNamespace;

namespace _11409_MaximChernykh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задачи со второй и третьей практики (нужно выделить время, чтобы добавить их сюда когда-нибудь)

            ///////////////////////////////////
            // Задачи с четвертой 21.11.2024 //
            ///////////////////////////////////

            // Задача №1 НАХОЖДЕНИЕ ЦИФР В СТРОКЕ
            //FindingNums findingNums = new FindingNums();
            //findingNums.FindNums();

            // Задача №2 КАПИАЛИЗАЦИЯ ТЕКСТА
            //CapitalizingText capitalizingText = new CapitalizingText();
            //capitalizingText.Capitalizing();

            // Задача №3 ПРОВЕРКА НА ПАЛИНДРОМНОСТЬ
            //Palindrom palindrom = new Palindrom();
            //palindrom.СheckPalindrom();

            // Задача №4 ПРОВЕРКА ДВУХ СТРОК НА АНАГРАММНОСТЬ
            //Anagramma anagramma = new Anagramma();
            //anagramma.isAnagramma();

            // Задача №5 НАЙТИ САМУЮ ДЛИННУЮ ПОДСТРОКУ
            Substring substring = new Substring();
            substring.SearchSubstring();
        }
    }
}
