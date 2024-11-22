using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Программу, которая осуществляет капитализацию введенного пользователем текста.
//В качестве разделителя слов использовать пробел.
namespace _11409_MaximChernykh.CapitalizingTextNamespace
{
    internal class CapitalizingText
    {
        public string Capitalizing()
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            Console.WriteLine(textInfo.ToTitleCase(text));
            return textInfo.ToTitleCase(text);
        }
    }
}
