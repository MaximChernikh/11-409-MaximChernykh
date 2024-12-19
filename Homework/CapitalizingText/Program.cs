using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Программу, которая осуществляет капитализацию введенного пользователем текста.
//В качестве разделителя слов использовать пробел.
namespace Homework
{
    internal class CapitalizingText
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            Console.WriteLine(textInfo.ToTitleCase(text));
        }
    }
}
